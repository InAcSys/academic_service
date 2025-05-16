using AcademicService.Application.Services.Interfaces;
using AcademicService.Domain.DTOs.Institute;
using AcademicService.Domain.Entities.Concretes;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AcademicService.Presentation.Controllers
{
    [ApiController, Route("api/[controller]")]
    public class InstituteController(
        IService<Institute, Guid> service,
        IMapper mapper
    ) : ControllerBase
    {
        private readonly IService<Institute, Guid> _service = service;
        private readonly IMapper _mapper = mapper;

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

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateInstituteDTO institute)
        {
            var entity = _mapper.Map<Institute>(institute);
            var result = await _service.Create(entity);
            if (result is null)
            {
                return BadRequest("Institute can not be created");
            }
            return Ok(result);
        }

        [HttpPut("id/{id}")]
        public async Task<IActionResult> Update([FromHeader] Guid id, [FromBody] UpdateInstituteDTO institute)
        {
            try
            {
                var entity = _mapper.Map<Institute>(institute);
                var result = await _service.Update(id, entity);
                return Ok(result);
            }
            catch (InvalidOperationException exception)
            {
                return BadRequest(exception.Message);
            }
        }

        [HttpDelete("id/{id}")]
        public async Task<IActionResult> Delete([FromHeader] Guid id)
        {
            var result = await _service.Delete(id);
            if (!result)
            {
                return BadRequest("The entity could not be eliminated");
            }
            return Ok("Was deleted!");
        }
    }
}