using LoanCalculator.Core.Entities;

namespace LoanCalculator.Core
{
    public class CalculationType : BaseEntity
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }
}
