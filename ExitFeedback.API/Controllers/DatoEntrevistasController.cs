using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ExitFeedback.DataAccess;
using ExitFeedback.Models.Entities;
using ExitFeedback.Models.Contracts;

namespace ExitFeedback.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DatoEntrevistasController : ControllerBase
    {
        private readonly IBaseService<DatoEntrevista> _service;

        public DatoEntrevistasController(IBaseService<DatoEntrevista> service)
        {
            _service = service;
        }

        // GET: api/DatoEntrevistas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DatoEntrevista>>> GetDatoEntrevistas()
        {
            var data = await _service.Find();
            return Ok(data);
        }

        // GET: api/DatoEntrevistas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DatoEntrevista>> GetDatoEntrevista(int id)
        {
            var data = await _service.GetById(id);

            if (data == null)
            {
                return NotFound();
            }

            return Ok(data);
        }

        /*
        // PUT: api/DatoEntrevistas/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDatoEntrevista(int id, DatoEntrevista datoEntrevista)
        {
            if (id != datoEntrevista.DatoEntrevistaId)
            {
                return BadRequest();
            }

            _context.Entry(datoEntrevista).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DatoEntrevistaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }
        */

        // POST: api/DatoEntrevistas
        [HttpPost]
        public async Task<ActionResult<DatoEntrevista>> PostDatoEntrevista(DatoEntrevista datoEntrevista)
        {

            DatoEntrevista data;
            if (datoEntrevista.DatoEntrevistaId != 0)
            {
                data = await _service.Update(datoEntrevista);
            }
            else
            {
                data = await _service.Create(datoEntrevista);
            }
            return Ok(data);
        }

        // DELETE: api/DatoEntrevistas/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DatoEntrevista>> DeleteDatoEntrevista(int id)
        {
            var datoEnt = await _service.GetById(id);
            if (datoEnt == null)
            {
                return NotFound();
            }

            var data = _service.Delete(id);

            return Ok(datoEnt);

        }
    }
}
