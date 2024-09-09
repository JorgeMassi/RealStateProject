using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealState.Application.Interfaces.Prices;
using RealState.Application.Interfaces.Properties;
using RealState.Domian.Model;

namespace RealState.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PriceController : ControllerBase
    {
        private readonly IPriceService _priceService;
        public PriceController(IPriceService priceService)
        {
            _priceService = priceService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _priceService.GetAll());
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _priceService.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Create(Price price)
        {
            return Ok(await _priceService.Create(price));
        }

        [HttpPut]
        public async Task<IActionResult> Update(Price price)
        {
            return Ok(await _priceService.Update(price));
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(Price price)
        {
            return Ok(await _priceService.Delete(price));
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _priceService.Delete(id));
        }
    }
}
