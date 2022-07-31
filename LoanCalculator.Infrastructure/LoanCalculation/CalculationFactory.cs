namespace LoanCalculator.Infrastructure.LoanCalculation
{
    public abstract class CalculationFactory
    {
        public abstract ICalculation GetCalculation(string code);
    }
}
