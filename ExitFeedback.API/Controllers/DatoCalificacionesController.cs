using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ExitFeedback.Models.Entities;
using ExitFeedback.Models.Contracts;

namespace ExitFeedback.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DatoCalificacionesController : ControllerBase
    {
        private readonly IBaseService<DatoCalificacion> _service;

        public DatoCalificacionesController(IBaseService<DatoCalificacion> service)
        {
            _service = service;
        }

        // GET: api/DatoCalificaciones
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DatoCalificacion>>> GetDatoCalificaciones()
        {
            var data = await _service.Find();
            return Ok(data);
        }

        // GET: api/DatoCalificaciones/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DatoCalificacion>> GetDatoCalificacion(int id)
        {
            var datoCalificacion = await _service.GetById(id);

            if (datoCalificacion == null)
            {
                return NotFound();
            }

            return Ok(datoCalificacion);
        }

        // POST: api/DatoCalificaciones
        [HttpPost]
        public async Task<ActionResult<DatoCalificacion>> PostDatoCalificacion(DatoCalificacion datoCalificacion)
        {
            DatoCalificacion data;
            if (datoCalificacion.DatoCalificacionId != 0)
            {
                data = await _service.Update(datoCalificacion);
            }
            else
            {
                data = await _service.Create(datoCalificacion);
            }
            return Ok(data);
        }

        // DELETE: api/DatoCalificaciones/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DatoCalificacion>> DeleteDatoCalificacion(int id)
        {
            var datoCalificacion = await _service.GetById(id);
            if (datoCalificacion == null)
            {
                return NotFound();
            }

            var data = _service.Delete(id);

            return Ok(datoCalificacion);


        }

    }
}
