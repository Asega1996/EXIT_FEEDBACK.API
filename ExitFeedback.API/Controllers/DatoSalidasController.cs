using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ExitFeedback.DataAccess;
using ExitFeedback.Models.Entities;
using ExitFeedback.Models.Contracts;

namespace ExitFeedback.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DatoSalidasController : ControllerBase
    {
        private readonly IBaseService<DatoSalida> _service;
        private readonly IBaseService<Registro> _registroService;

        public DatoSalidasController(IBaseService<DatoSalida> service,
                                    IBaseService<Registro> registroServivce)
        {
            _service = service;
            _registroService = registroServivce;
        }

        // GET: api/DatoSalidas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DatoSalida>>> GetDatoSalidas()
        {
            var data = await _service.Find();
            return Ok(data);
        }

        // GET: api/DatoSalidas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DatoSalida>> GetDatoSalida(int id)
        {
            var datoSalida = await _service.GetById(id);
            return Ok(datoSalida);
        }

        
        // PUT: api/DatoSalidas/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutDatoSalida(int registroId, DatoSalida datoSalida)
        //{
        //    var registro = _registroService.GetById(registroId);

        //    if (registro == null)
        //    {
        //        return BadRequest("Registro not found");
        //    }

        //    registro.

        //    return Ok(datoSalida);
        //}
        

        // POST: api/DatoSalidas
        [HttpPost]
        public async Task<ActionResult<DatoSalida>> PostDatoSalida(DatoSalida datoSalida)
        {
            DatoSalida data;
            if (datoSalida.DatoSalidaId != 0)
            {
                data = await _service.Update(datoSalida);
            }
            else
            {
                data = await _service.Create(datoSalida);
            }
            return Ok(data);
        }

        // DELETE: api/DatoSalidas/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DatoSalida>> DeleteDatoSalida(int id)
        {
            var datoSalida = await _service.GetById(id);
            if (datoSalida == null)
            {
                return NotFound();
            }

            var data = _service.Delete(id);

            return Ok(datoSalida);
        }
    }
}
