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
    public class ProyectoController : ControllerBase
    {
        private readonly IBaseService<Proyecto> _service;

        public ProyectoController(IBaseService<Proyecto> service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Proyecto>>> Get()
        {
            IEnumerable titulaciones = await _service.Find();
            return Ok(titulaciones);

        }
    }
}
