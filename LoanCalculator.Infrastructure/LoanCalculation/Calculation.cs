namespace LoanCalculator.Infrastructure.LoanCalculation
{
    public class Calculation : CalculationFactory
    {
        public override ICalculation GetCalculation(string code)
        {
            switch (code)
            {
                case "EMI":
                    return new EMI();
                default:
                    return new M2();
            }
        }
    }
}
