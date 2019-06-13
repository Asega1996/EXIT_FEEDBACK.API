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
    public class DatoEmpleadosController : ControllerBase
    {
        private readonly IBaseService<DatoEmpleado> _service;

        public DatoEmpleadosController(IBaseService<DatoEmpleado> service)
        {
            _service = service;
        }

        // GET: api/DatoEmpleados
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DatoEmpleado>>> GetDatoEmpleados()
        {
            var data = await _service.Find();
            return Ok(data);
        }

        // GET: api/DatoEmpleados/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DatoEmpleado>> GetDatoEmpleado(int id)
        {
            var data = await _service.GetById(id);

            if (data == null)
            {
                return NotFound();
            }

            return Ok(data);
        }

        /*
        // PUT: api/DatoEmpleados/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDatoEmpleado(int id, DatoEmpleado datoEmpleado)
        {
            if (id != datoEmpleado.DatoEmpleadoId)
            {
                return BadRequest();
            }

            _context.Entry(datoEmpleado).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DatoEmpleadoExists(id))
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

        // POST: api/DatoEmpleados
        [HttpPost]
        public async Task<ActionResult<DatoEmpleado>> PostDatoEmpleado(DatoEmpleado datoEmpleado)
        {
            DatoEmpleado data; 
            if (datoEmpleado.DatoEmpleadoId != 0) {
                data = await _service.Update(datoEmpleado);
            }
            else
            { 
                data = await _service.Create(datoEmpleado);
            }
            return Ok(data);
        }

        // DELETE: api/DatoEmpleados/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DatoEmpleado>> DeleteDatoEmpleado(int id)
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
