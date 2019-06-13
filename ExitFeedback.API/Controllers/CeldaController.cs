using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using ExitFeedback.Models.Contracts;
using ExitFeedback.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ExitFeedback.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CeldaController : ControllerBase
    {
        private readonly IBaseService<Celda> _service;

        public CeldaController(IBaseService<Celda> service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Celda>>> Get()
        {
            IEnumerable titulaciones = await _service.Find();
            return Ok(titulaciones);

        }
    }
}