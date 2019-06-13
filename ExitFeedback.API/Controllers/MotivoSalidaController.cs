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
    public class MotivoSalidaController : ControllerBase
    {
        private readonly IBaseService<MotivoSalida> _service;

        public MotivoSalidaController(IBaseService<MotivoSalida> service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<MotivoSalida>>> Get()
        {
            IEnumerable data = await _service.Find();
            return Ok(data);

        }
    }
}