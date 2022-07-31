using LoanCalculator.Shared.CalculationTypes;

namespace LoanCalculator.Infrastructure.Services
{
    public interface ICalculationTypeService
    {
        Task<IEnumerable<CalculationTypeDto>> GetAsync();
        Task<CalculationTypeDto> GetByIdAsync(long id);
    }
}
