using LoanCalculator.Core;
using Microsoft.EntityFrameworkCore;

namespace LoanCalculator.Infrastructure.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<CalculationType> CalculationTypes { get; set; }
    }
}
