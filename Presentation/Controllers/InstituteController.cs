using AcademicService.Application.Services.Interfaces;
using AcademicService.Domain.Entities.Concretes;
using Microsoft.AspNetCore.Mvc;

namespace AcademicService.Presentation.Controllers
{
    [ApiController, Route("api/[controller]")]
    public class InstituteController(
        IService<Institute, Guid> service
    ) : ControllerBase
    {
        private readonly IService<Institute, Guid> _service = service;

        [HttpGet]
        public async Task<IActionResult> GetAll(
            [FromQuery] int pageNumber = 1,
            [FromQuery] int pageSize = 10
        )
        {
            var institutes = await _service.GetAll(pageNumber, pageSize);
            return Ok(institutes);
        }

        [HttpGet("id/{id}")]
        public async Task<IActionResult> GetById([FromHeader] Guid id)
        {
            var institute = await _service.GetById(id);
            if (institute is null)
            {
                return NotFound();
            }
            return Ok(institute);
        }
    }
}