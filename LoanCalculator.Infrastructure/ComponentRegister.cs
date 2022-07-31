using LoanCalculator.Infrastructure.Mapper;
using LoanCalculator.Infrastructure.Models;
using LoanCalculator.Infrastructure.Repository;
using LoanCalculator.Infrastructure.Services;
using LoanCalculator.Infrastructure.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace LoanCalculator.Infrastructure
{
    public static class ComponentRegister
    {
        public static void AddDbContext<TContext>(IServiceCollection serviceCollection, IConfiguration configuration, string connectionString)
            where TContext : DbContext
        {
            serviceCollection.AddDbContext<TContext>(m => m.UseSqlServer(configuration.GetConnectionString(connectionString)), ServiceLifetime.Singleton);
        }

        public static void RegisterDbContext(this IServiceCollection serviceCollection, IConfiguration configuration, string connectionString = "DefaultConnection")
        {
            AddDbContext<ApplicationDbContext>(serviceCollection, configuration, connectionString);
        }

        public static void RegisterComponents(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IUnitOfWork, UnitOfWork.UnitOfWork>();
            serviceCollection.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            serviceCollection.AddScoped<ICalculationTypeService, CalculationTypeService>();
            serviceCollection.AddScoped<ICalculationService, CalculationService>();
        }

        public static void AddAutoMapper(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddAutoMapper(typeof(AutoMapperConfiguration));
        }
    }
}
