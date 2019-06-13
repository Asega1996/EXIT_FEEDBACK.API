using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExitFeedback.Models.Contracts;
using ExitFeedback.Models.Entities;
using ExitFeedback.Models.Enum;
using Microsoft.AspNetCore.Mvc;

namespace ExitFeedback.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistroController : ControllerBase
    {

        private readonly IBaseService<Registro> _service;

        public RegistroController(IBaseService<Registro> service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Registro>>> GetAll() {
            var listaRegistro = await _service.Find();
            return Ok(listaRegistro);
        }


        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Registro>> Get(int id)
        {
            var listaRegistro = await _service.FindWhere(x => x.EmpleadoId == id && x.Status != (int)StatusEnum.Completed);
            var registro = listaRegistro.OrderByDescending(x => x.RegistroId).FirstOrDefault();

            if (registro == default(Registro))
            {
                var registroCreate = new Registro();
                
                registroCreate.EmpleadoId = id;
                registroCreate.Status = (int) StatusEnum.Draft;
                return await _service.Create(registroCreate);
            }

            else return Ok(registro);
        }

        [HttpPost]
        public async Task<ActionResult<Registro>> Post(Registro registro) {
            
            Registro reg = await _service.GetById(registro.RegistroId);

            if (registro.DatosEmpleadoId != 0 && registro.DatosEmpleadoId != null) {
                reg.DatosEmpleadoId = registro.DatosEmpleadoId;
            }

            if (registro.DatosSalidaId != 0 && registro.DatosSalidaId != null) { reg.DatosSalidaId = registro.DatosSalidaId; }

            if (registro.DatosCalificacionesId != 0 && registro.DatosCalificacionesId != null) { reg.DatosCalificacionesId = registro.DatosCalificacionesId; }

            if (registro.DatosEntrevistaId != 0 && registro.DatosEntrevistaId != null) { reg.DatosEntrevistaId = registro.DatosEntrevistaId; }


            if (reg.DatosEntrevistaId != null  && reg.DatosCalificacionesId != null &&
                reg.DatosSalidaId != null && reg.DatosEmpleadoId != null)
            {
                reg.Status = (int)StatusEnum.Completed;
            }
            else { reg.Status = (int) StatusEnum.Draft; }

            var result = await _service.Update(reg);

            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Registro>> Put(int id, [FromBody] Registro registro)
        {
            var result = await _service.Update(registro);

            return Ok(result);
        }


    }
}