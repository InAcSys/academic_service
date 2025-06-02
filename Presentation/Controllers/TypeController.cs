using AcademicService.Application.Services.Interfaces;
using AcademicService.Domain.Entities.Concretes;
using Microsoft.AspNetCore.Mvc;

namespace AcademicService.Presentation.Controllers
{
    [ApiController, Route("api/[controller]")]
    public class TypeController(
        IService<InstituteType, int> service
    ) : ControllerBase
    {
        private readonly IService<InstituteType, int> _service = service;

        [HttpGet]
        public async Task<IActionResult> GetAll(
            [FromQuery] int pageNumber = 1,
            [FromQuery] int pageSize = 10
        )
        {
            if (pageNumber < 1)
            {
                return BadRequest("Page number must be greater than or equal to 1.");
            }
            if (pageSize < 1)
            {
                return BadRequest("Page size must be greater than or equal to 1.");
            }

            var types = await _service.GetAll(pageNumber, pageSize);
            return Ok(types);
        }
    }
}