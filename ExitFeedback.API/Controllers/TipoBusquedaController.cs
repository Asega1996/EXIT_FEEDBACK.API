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
    public class TipoBusquedaController : ControllerBase
    {
        private readonly IBaseService<TipoBusqueda> _service;

        public TipoBusquedaController(IBaseService<TipoBusqueda> service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TipoBusqueda>>> Get()
        {
            IEnumerable data = await _service.Find();
            return Ok(data);

        }
    }
}