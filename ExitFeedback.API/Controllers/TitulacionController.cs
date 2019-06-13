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
    public class TitulacionController : ControllerBase
    {
        private readonly IBaseService<Titulacion> _service;

        public TitulacionController(IBaseService<Titulacion> service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Titulacion>>> Get()
        {
            IEnumerable titulaciones = await _service.Find();
            return Ok(titulaciones);

        }
    }
}