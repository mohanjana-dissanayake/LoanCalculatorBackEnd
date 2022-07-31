using LoanCalculator.Infrastructure.Services;
using LoanCalculator.Shared.CalculationTypes;
using Microsoft.AspNetCore.Mvc;

namespace LoanCalculator.Api.Controllers
{
    [Route("api/calculation-type")]
    [ApiController]
    public class CalculationTypeController : ControllerBase
    {
        private readonly ICalculationTypeService _service;

        public CalculationTypeController(ICalculationTypeService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IEnumerable<CalculationTypeDto>> GetCalculationTypesAsync() 
        {
            return await Task.FromResult(await _service.GetAsync());
        }

        [HttpGet("{id}")]
        public async Task<CalculationTypeDto> GetCalculationTypeByIdAsync(long id)
        {
            return await Task.FromResult(await _service.GetByIdAsync(id));
        }
    }
}
