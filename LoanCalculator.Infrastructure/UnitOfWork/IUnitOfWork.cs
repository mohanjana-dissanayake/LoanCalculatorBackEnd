using LoanCalculator.Core;
using LoanCalculator.Infrastructure.Repository;

namespace LoanCalculator.Infrastructure.UnitOfWork
{
    public interface IUnitOfWork : IBaseUnitOfWork
    {
        public IRepository<CalculationType> CalculationTypeRepository { get; }
    }
}
