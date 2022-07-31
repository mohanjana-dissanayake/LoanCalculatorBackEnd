namespace LoanCalculator.Infrastructure.UnitOfWork
{
    public interface IBaseUnitOfWork
    {
        Task BeginTransactionAsync();
        Task CommitAsync();
        Task RollbackAsync();
        Task SaveChangesAsync();
    }
}
