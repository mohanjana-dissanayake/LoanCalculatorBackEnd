using AutoMapper;
using LoanCalculator.Core;
using LoanCalculator.Infrastructure.UnitOfWork;
using LoanCalculator.Shared.CalculationTypes;

namespace LoanCalculator.Infrastructure.Services
{
    public class CalculationTypeService : ICalculationTypeService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CalculationTypeService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            this._mapper = mapper;
        }

        public async Task<IEnumerable<CalculationTypeDto>> GetAsync()
        {
            var predicate = PredicateBuilder.True<CalculationType>();
            predicate = predicate.And(x => x.IsActive == true);
            predicate = predicate.And(x => x.IsDeleted == false);
            return await Task.FromResult(_mapper.Map<IEnumerable<CalculationTypeDto>>(await _unitOfWork.CalculationTypeRepository.GetAync(filter: predicate)));
        }

        public async Task<CalculationTypeDto> GetByIdAsync(long id)
        {
            

            return await Task.FromResult(_mapper.Map<CalculationTypeDto>(await _unitOfWork.CalculationTypeRepository.GetByIdAsync(id)));
        }
    }
}
