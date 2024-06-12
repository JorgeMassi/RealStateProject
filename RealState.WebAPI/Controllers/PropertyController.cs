using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealState.Application.Interfaces.Properties;
using RealState.Domian.Model;

namespace RealState.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class propertyController : ControllerBase
    {
        private readonly IPropertyService _service;
        public propertyController(IPropertyService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _service.GetAll());
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(await _service.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Create(Property property)
        {
            return Ok(await _service.Create(property));
        }

        [HttpPut]
        public async Task<IActionResult> Update(Property property)
        {
            return Ok(await _service.Update(property));
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(Property property)
        {
            return Ok(await _service.Delete(property));
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            return Ok(await _service.Delete(id));
        }
    }
}
