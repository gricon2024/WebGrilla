using Microsoft.AspNetCore.Mvc;
using WebGrilla.DTOs;
using WebGrilla.Services;

namespace WebGrilla.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TemaController : ControllerBase
    {
        private readonly TemaService _temaService;

        public TemaController(TemaService temaService)
        {
            _temaService = temaService;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TemaDTO>>> GetAll()
        {
            var temas = await _temaService.GetAllAsync();
            return Ok(temas);
        }
        [HttpGet("{Id}")]
        public async Task<ActionResult<TemaDTO>> GetById(int Id)
        {
            var tema = await _temaService.GetByIdAsync(Id);
            if (tema == null)
            {
                return NotFound();
            }
            return Ok(tema);
        }

    }

}
