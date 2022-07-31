using AutoMapper;
using LoanCalculator.Core;
using LoanCalculator.Shared.CalculationTypes;

namespace LoanCalculator.Infrastructure.Mapper
{
    public class AutoMapperConfiguration : Profile
    {
        public AutoMapperConfiguration()
        {
            CreateMap<CalculationTypeDto, CalculationType>().ReverseMap();
        }
    }
}
