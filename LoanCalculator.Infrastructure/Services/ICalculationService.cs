namespace LoanCalculator.Infrastructure.Services
{
    public interface ICalculationService
    {
        public Task<decimal> CalculateAsync(long typeId, decimal principalAmount, decimal rate, int noOfPayments);
    }
}
