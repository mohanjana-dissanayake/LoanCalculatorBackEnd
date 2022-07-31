using LoanCalculator.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Migrator
{
    public class DbMigrator : IDbMigrator
    {
        public DbMigrator(ApplicationDbContext context)
        {
            _context = context;
        }

        private readonly ApplicationDbContext _context;

        public async Task MigrateDbChanges()
        {
            try
            {
                var pendingMigrations = _context.Database.GetPendingMigrations();

                if (pendingMigrations.Any())
                {
                    Console.WriteLine($"You have {pendingMigrations.Count()} pending migrations to apply.");
                    Console.WriteLine($"Do you have wish to continue? (y/n)");
                    var input = Console.ReadLine();

                    if (input.ToLower() != "y")
                    {
                        return;
                    }

                    Console.WriteLine("Applying pending migrations now");
                    _context.Database.Migrate();
                }

                var lastAppliedMigration = (_context.Database.GetAppliedMigrations()).Last();
                Console.WriteLine($"You're on schema version: {lastAppliedMigration}");
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
