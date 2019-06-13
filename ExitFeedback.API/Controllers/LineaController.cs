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
    public class LineaController : ControllerBase
    {
        private readonly IBaseService<Linea> _service;

        public LineaController(IBaseService<Linea> service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Linea>>> Get()
        {
            IEnumerable data = await _service.Find();
            return Ok(data);

        }
    }
}