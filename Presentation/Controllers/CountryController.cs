using AcademicService.Application.Services.Interfaces;
using AcademicService.Domain.Entities.Concretes;
using Microsoft.AspNetCore.Mvc;

namespace AcademicService.Presentation.Controllers
{
    [ApiController, Route("api/[controller]")]
    public class CountryController(
        IService<Country, int> service
    ) : ControllerBase
    {
        private readonly IService<Country, int> _service = service;

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var entities = await _service.GetAll(1, 200);
            return Ok(entities);
        }
    }
}