using Microsoft.AspNetCore.Mvc;
using RealState.Application.Interfaces.Propertizz.Addresses;
using RealState.Domian.Model.Properties;

namespace RealState.API.Controllers.Propertizz
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IAddressService _addressService;
        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _addressService.GetAll());
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _addressService.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Create(Address address)
        {
            return Ok(await _addressService.Create(address));
        }

        [HttpPut]
        public async Task<IActionResult> Update(Address address)
        {
            return Ok(await _addressService.Update(address));
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(Address address)
        {
            return Ok(await _addressService.Delete(address));
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _addressService.Delete(id));
        }
    }
}
