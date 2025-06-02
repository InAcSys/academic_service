using AcademicService.Application.Services.Interfaces;
using AcademicService.Domain.DTOs.Institute;
using AcademicService.Domain.Entities.Concretes;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AcademicService.Presentation.Controllers
{
    [ApiController, Route("api/[controller]")]
    public class InstituteController(
        IInstituteService service,
        IMapper mapper
    ) : ControllerBase
    {
        private readonly IInstituteService _service = service;
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
        public async Task<IActionResult> GetById([FromRoute] Guid id)
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
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] UpdateInstituteDTO institute)
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
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var result = await _service.Delete(id);
            if (!result)
            {
                return BadRequest("The entity could not be eliminated");
            }
            return Ok("Was deleted!");
        }

        [HttpPost("assign-principal/id/{id}")]
        public async Task<IActionResult> AssignPrincipal([FromRoute] Guid id, [FromBody] AssignPrincipalDTO principalDTO)
        {
            var result = await _service.AssignPrincipal(id, principalDTO.Principal);
            if (!result)
            {
                return BadRequest("It was not possible to assign the director");
            }
            return Ok(result);
        }

        [HttpPost("verify-subdomain")]
        public async Task<IActionResult> VerifySUbDomain([FromQuery] string subDomain)
        {
            var result = await _service.VerifySubDomainIsUnique(subDomain);
            return Ok(result);
        }
    }
}