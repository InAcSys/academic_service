using AcademicService.Application.Services.Interfaces;
using AcademicService.Domain.Entities.Concretes;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace AcademicService.Presentation.Controllers
{
    [ApiController, Route("api/[controller]")]
    public class DepartmentController
    (
        IChildService<Departament, int, int> service
    ) : ControllerBase
    {
        private readonly IChildService<Departament, int, int> _service = service;

        [HttpGet("parent-id/{id}")]
        public async Task<IActionResult> GetAllByParentId([FromRoute] int id)
        {
            var result = await _service.GetAllByParentId(id);
            return Ok(result);
        }
    }
}