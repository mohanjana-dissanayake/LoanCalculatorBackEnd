namespace LoanCalculator.Infrastructure.LoanCalculation
{
    public interface ICalculation
    {
        Task<decimal> CalculateInstallment(decimal principalAmount, decimal rate, int noOfPayments);
    }
}
