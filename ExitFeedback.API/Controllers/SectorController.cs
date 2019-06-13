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
    public class SectorController : ControllerBase
    {
        private readonly IBaseService<Sector> _service;

        public SectorController(IBaseService<Sector> service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Sector>>> Get()
        {
            IEnumerable data = await _service.Find();
            return Ok(data);

        }
    }
}