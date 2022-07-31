using LoanCalculator.Core;
using LoanCalculator.Infrastructure.Models;
using LoanCalculator.Infrastructure.Repository;

namespace LoanCalculator.Infrastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        private IRepository<CalculationType> _calculationTypeRepository;
        public IRepository<CalculationType> CalculationTypeRepository => _calculationTypeRepository?? new Repository<CalculationType>(_context);

        public async Task BeginTransactionAsync()
        {
            await _context.Database.BeginTransactionAsync();
        }

        public async Task CommitAsync()
        {
            await _context.Database.CommitTransactionAsync();
        }

        public async Task RollbackAsync()
        {
            await _context.Database.RollbackTransactionAsync();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
