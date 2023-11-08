using Microsoft.AspNetCore.Mvc;
using PricetoolAPI.Application.DTOs;
using PricetoolAPI.Application.Services;

namespace PricetoolAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubsidiaryController : ControllerBase
    {
        private readonly ISubsidiaryService _service;

        public SubsidiaryController(ISubsidiaryService service)
        {
            _service = service;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<SubsidiaryDTO>))]
        public async Task<IActionResult> GetAllSubsidiaries()
        {
            var subsidiaries = await _service.GetAllSubsidiariesAsync();
            return Ok(subsidiaries);
        }

        [HttpGet("{cvr}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SubsidiaryDTO))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetSubsidiaryByCvr(int cvr)
        {
            var subsidiary = await _service.GetSubsidiaryByCvrAsync(cvr);
            if (subsidiary == null) return NotFound();
            return Ok(subsidiary);
        }

        [HttpGet("{cvr}/products")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SubsidiaryWithProductsDTO))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetSubsidiaryWithProductsByCvr(int cvr)
        {
            var subsidiary = await _service.GetSubsidiaryWithProductsByCvrAsync(cvr);
            if (subsidiary == null) return NotFound();
            return Ok(subsidiary);
        }


    }
}
