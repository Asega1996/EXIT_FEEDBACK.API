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
    public class TipoEmpresaController : ControllerBase
    {
        private readonly IBaseService<TipoEmpresa> _service;

        public TipoEmpresaController(IBaseService<TipoEmpresa> service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TipoEmpresa>>> Get()
        {
            IEnumerable data = await _service.Find();
            return Ok(data);

        }
    }
}