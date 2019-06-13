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
    public class SubmotivoSalidaController : ControllerBase
    {
        private readonly IBaseService<SubmotivoSalida> _service;

        public SubmotivoSalidaController(IBaseService<SubmotivoSalida> service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<SubmotivoSalida>>> Get()
        {
            IEnumerable data = await _service.Find();
            return Ok(data);

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<SubmotivoSalida>>> GetByMotivoSalida(int id)
        {
            IEnumerable data = await _service.FindWhere(x => x.MotivoSalidaId == id);
            return Ok(data);

        }

    }
}