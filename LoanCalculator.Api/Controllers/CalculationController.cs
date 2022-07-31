using LoanCalculator.Infrastructure.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoanCalculator.Api.Controllers
{
    [Route("api/calculation")]
    [ApiController]
    public class CalculationController : ControllerBase
    {
        private readonly ICalculationService _service;

        public CalculationController(ICalculationService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<decimal> GetInstallment(long typeId, decimal principalAmount, decimal rate, int noOfPayments)
        {
            return await Task.FromResult(await _service.CalculateAsync(typeId, principalAmount, rate, noOfPayments));
        }
    }
}
