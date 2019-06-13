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
    public class TecnologiaController : ControllerBase
    {
        private readonly IBaseService<Tecnologia> _service;

        public TecnologiaController(IBaseService<Tecnologia> service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tecnologia>>> Get()
        {
            IEnumerable data = await _service.Find();
            return Ok(data);

        }
    }
}