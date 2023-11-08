using Microsoft.AspNetCore.Mvc;
using PricetoolAPI.Application.DTOs;
using PricetoolAPI.Application.Services;


namespace PricetoolAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CorporateController : ControllerBase
    {
        private readonly ICorporateService _service;

        public CorporateController(ICorporateService service)
        {
            _service = service;
        }

        [HttpGet("{cvr}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CorporateDTO))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetCorporateByCvr(int cvr)
        {
            var corporate = await _service.GetCorporateByCvrAsync(cvr);
            if (corporate == null) return NotFound();
            return Ok(corporate);
        }


        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<CorporateWithoutSubsidiariesDTO>))]
        public async Task<IActionResult> GetAllCorporates()
        {
            var corporates = await _service.GetAllCorporatesAsync();
            Console.WriteLine(corporates);
            return Ok(corporates);
        }

    }
}
