namespace LoanCalculator.Infrastructure.LoanCalculation
{
    public class EMI : ICalculation
    {
        public async Task<decimal> CalculateInstallment(decimal principalAmount, decimal rate, int noOfPayments)
        {
            var expression1 = 1 + rate; // 1+r
            var expression2 = Math.Pow(Convert.ToDouble(expression1), noOfPayments); //(1+r)^n
            var expression3 = Convert.ToDecimal(expression2) * rate; // r((1+r)^n)
            var expression4 = expression2 - 1;  //(1+r)^n - 1
            var expression5 = expression3 / Convert.ToDecimal(expression4); 
            var expression6 = expression5 * principalAmount;
            //var installment = principalAmount * Convert.ToDecimal(((Math.Pow(noOfPayments, (double)((1 + rate) * rate)) / (Math.Pow(noOfPayments, (double)((1 + rate) * rate)) - 1))));
            return await Task.FromResult(expression6);
        }
    }
}
