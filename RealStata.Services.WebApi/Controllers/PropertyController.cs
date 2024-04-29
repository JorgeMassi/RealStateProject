using Microsoft.AspNetCore.Mvc;
using RealState.Application.Dto;
using RealState.Application.Interfaces.Properties;


namespace RealState.Services.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropertyController : ControllerBase
    {
        private readonly IPropertyService _propertyService;

        public PropertyController(IPropertyService propertyService)
        {
            _propertyService = propertyService;
        }


        [HttpGet]
        public IEnumerable<PropertyDto> Get()
        {
            return (IEnumerable<PropertyDto>)_propertyService.GetAll();
        }

        [HttpGet("{id}")]
        public PropertyDto Get(Guid id)
        {
            return null;
            //return _propertyService.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody] PropertyDto property)
        {
            _propertyService.Create(property);
        }

        [HttpPut]
        public void Put([FromBody] PropertyDto property)
        {
            _propertyService.Update(property);
        }

        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _propertyService.Delete(id);
        }
    }
}
