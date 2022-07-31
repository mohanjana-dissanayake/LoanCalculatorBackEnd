using LoanCalculator.Infrastructure.LoanCalculation;

namespace LoanCalculator.Infrastructure.Services
{
    public class CalculationService : ICalculationService
    {
        private readonly ICalculationTypeService _calculationTypeService;

        public CalculationService(ICalculationTypeService calculationTypeService)
        {
            _calculationTypeService = calculationTypeService;
        }

        public async Task<decimal> CalculateAsync(long typeId, decimal principalAmount, decimal rate, int noOfPayments)
        {
            if (typeId == 0)
                throw new Exception("Missing type. Bad Request");

            var type = await _calculationTypeService.GetByIdAsync(typeId);

            if (type == null)
                throw new Exception("Missing type. Bad Request");

            var calculation = new Calculation().GetCalculation(type.Code);
            return await Task.FromResult(await calculation.CalculateInstallment(principalAmount, rate, noOfPayments));
        }
    }
}
