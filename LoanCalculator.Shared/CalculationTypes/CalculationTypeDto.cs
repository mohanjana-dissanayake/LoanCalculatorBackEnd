using LoanCalculator.Core.Dto;

namespace LoanCalculator.Shared.CalculationTypes
{
    public class CalculationTypeDto : BaseEntityDto
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }
}
