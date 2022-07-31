using LoanCalculator.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Migrator;

var serviceProvider = new ServiceCollection().AddScoped<IDbMigrator, DbMigrator>();

var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);
IConfiguration config = builder.Build();
serviceProvider.RegisterDbContext(config);

using (var scope = serviceProvider.BuildServiceProvider())
{
    var dbMigrator = scope.GetRequiredService<IDbMigrator>();
    dbMigrator.MigrateDbChanges();
}