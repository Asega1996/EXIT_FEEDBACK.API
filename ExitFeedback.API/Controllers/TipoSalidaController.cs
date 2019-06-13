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
    public class TipoSalidaController : ControllerBase
    {
        private readonly IBaseService<TipoSalida> _service;

        public TipoSalidaController(IBaseService<TipoSalida> service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TipoSalida>>> Get()
        {
            IEnumerable data = await _service.Find();
            return Ok(data);

        }
    }
}