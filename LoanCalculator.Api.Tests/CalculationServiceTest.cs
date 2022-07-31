using LoanCalculator.Infrastructure.LoanCalculation;

namespace LoanCalculator.Api.Tests
{
    [TestClass]
    public class CalculationServiceTest
    {
        [TestMethod]
        public async Task CalculateAsyncMethod()
        {
            decimal principalAmount = 3500;
            decimal rate = 0.0067m;
            int noOfPayments = 36;
            EMI emi = new EMI();
            var result = Math.Round(await emi.CalculateInstallment(principalAmount, rate, noOfPayments), 2);
            Assert.AreEqual(109.74m, result);
        }
    }
}