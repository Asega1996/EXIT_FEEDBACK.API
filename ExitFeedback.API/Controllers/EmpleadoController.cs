using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExitFeedback.Models.Contracts;
using ExitFeedback.Models.Entities;
using ExitFeedback.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExitFeedback.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoController : ControllerBase
    {
        private readonly IBaseService<Empleado> _service;

        public EmpleadoController(IBaseService<Empleado> service)
        {
            _service = service;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Empleado>> Get(int id)
        {
            var employee = await _service.GetById(id);
            if (employee != default(Empleado))
                return Ok(employee);
            return BadRequest();
        }

        [HttpGet("numempleado/{ne}")]
        public async Task<ActionResult<Empleado>> GetNumEmpleado(int ne)
        {
            var employee = await _service.FindWhere(e => e.NumEmpleado == ne);

            if (employee != default(IEnumerable<Empleado>))
                return Ok(employee.FirstOrDefault());
            return BadRequest();
        }

        [HttpPost]
        public async Task<ActionResult<IEnumerable<Empleado>>> Post(Empleado empleado)
        {
            IEnumerable<Empleado> empleados = null;

            if ( !string.IsNullOrEmpty(empleado.NombreEmpleado) && !string.IsNullOrEmpty(empleado.ApellidoEmpleado))
            {
                empleados = await _service.FindWhere(x => x.ApellidoEmpleado == empleado.ApellidoEmpleado &&
                x.NombreEmpleado == empleado.NombreEmpleado);
            }

            if (string.IsNullOrEmpty(empleado.NombreEmpleado) && !string.IsNullOrEmpty(empleado.ApellidoEmpleado))
            {
                empleados = await _service.FindWhere(x => x.ApellidoEmpleado == empleado.ApellidoEmpleado);
            }

            if (!string.IsNullOrEmpty(empleado.NombreEmpleado) && string.IsNullOrEmpty(empleado.ApellidoEmpleado))
            {
                empleados = await _service.FindWhere(x => x.NombreEmpleado == empleado.NombreEmpleado);
            }

            return Ok(empleados);

        }
    }
}