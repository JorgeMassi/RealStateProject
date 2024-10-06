using Microsoft.AspNetCore.Mvc;
using RealState.Application.Interfaces.Propertizz.Typologies;
using RealState.Domian.Model.Properties;

namespace RealState.API.Controllers.Propertizz
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypologyController : ControllerBase
    {
        private readonly ITypologyService _typologyService;
        public TypologyController(ITypologyService typologyService)
        {
            _typologyService = typologyService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _typologyService.GetAll());
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _typologyService.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Create(Typology typology)
        {
            return Ok(await _typologyService.Create(typology));
        }

        [HttpPut]
        public async Task<IActionResult> Update(Typology typology)
        {
            return Ok(await _typologyService.Update(typology));
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(Typology typology)
        {
            return Ok(await _typologyService.Delete(typology));
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _typologyService.Delete(id));
        }
    }
}
