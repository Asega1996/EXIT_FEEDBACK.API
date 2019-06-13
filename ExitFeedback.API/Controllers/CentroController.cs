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
    public class CentroController : ControllerBase
    {
        private readonly IBaseService<Centro> _service;

        public CentroController(IBaseService<Centro> service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Centro>>> Get()
        {
            IEnumerable data = await _service.Find();
            return Ok(data);

        }
    }
}