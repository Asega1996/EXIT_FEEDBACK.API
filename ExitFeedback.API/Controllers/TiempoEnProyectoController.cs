using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExitFeedback.Models.Contracts;
using ExitFeedback.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExitFeedback.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TiempoEnProyectoController : ControllerBase
    {
        private readonly IBaseService<TiempoEnProyecto> _service;

        public TiempoEnProyectoController(IBaseService<TiempoEnProyecto> service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TiempoEnProyecto>>> Get()
        {
            IEnumerable data = await _service.Find();
            return Ok(data);

        }
    }
}