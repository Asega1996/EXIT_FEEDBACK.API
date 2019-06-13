using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExitFeedback.Models.Contracts;
using ExitFeedback.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ExitFeedback.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FetchRegistroController : ControllerBase
    {
        private readonly IBaseService<Empleado> _serviceEmpleado;
        private readonly IBaseService<Registro> _serviceRegistro;
        private readonly IBaseService<Celda> _serviceCelda;
        private readonly IBaseService<Linea> _serviceLinea;
        private readonly IBaseService<DatoSalida> _serviceDatoSalida;
        private readonly IBaseService<Centro> _serviceCentro;

        public FetchRegistroController(IBaseService<Empleado> serviceEmpleado, 
            IBaseService<Registro> serviceRegistro,
            IBaseService<Celda> serviceCelda,
            IBaseService<Linea> serviceLinea,
            IBaseService<DatoSalida> serviceDatoSalida,
            IBaseService<Centro> serviceCentro)
        {
            _serviceEmpleado = serviceEmpleado;
            _serviceRegistro = serviceRegistro;
            _serviceCelda = serviceCelda;
            _serviceLinea = serviceLinea;
            _serviceDatoSalida = serviceDatoSalida;
            _serviceCentro = serviceCentro;
        }

        [HttpGet]
        public async Task<ActionResult<CustomReg>> Get()
        {
            
            var listaRegs = await _serviceRegistro.Find();
            CustomReg[] customRegs = new CustomReg[listaRegs.Count()];
            
            int i = 0;
            foreach (Registro registro in listaRegs) {
                CustomReg customReg = new CustomReg();
                var emp = await _serviceEmpleado.GetById(registro.EmpleadoId);
                var cel = await _serviceCelda.GetById(emp.CeldaId);
                var lin = await _serviceLinea.GetById(emp.LineaId);
                customReg.Nombre = emp.NombreEmpleado;
                customReg.Apellidos = emp.ApellidoEmpleado;
                customReg.Numempleado = emp.NumEmpleado;
                customReg.Celda = cel.NombreCelda;
                customReg.Linea = lin.NombreLinea;
                if (registro.Status == 1)
                {
                    customReg.Finalizado = false;
                }
                else
                {
                    customReg.Finalizado = true;
                }
                

                if (registro.DatosSalidaId != null)
                {
                    var datoSalida = await _serviceDatoSalida.GetById(registro.DatosSalidaId.Value);
                    customReg.FechaSalida = datoSalida.FechaBaja;
                }

                customRegs[i] = customReg;
                i++;
            }

            return Ok(customRegs);
        }

        
        [HttpPost]
        public async Task<ActionResult<CustomReg>> Post(CustomReg reg) {

            var empleadoQuery = await _serviceEmpleado.Find();

            if (reg.Numempleado != 0)
            {
                empleadoQuery = empleadoQuery.Where(x => x.NumEmpleado == reg.Numempleado);
            }
            if (!string.IsNullOrEmpty(reg.Nombre))
            {
                empleadoQuery = empleadoQuery.Where(x => reg.Nombre == x.NombreEmpleado);
            }
            if (!string.IsNullOrEmpty(reg.Apellidos))
            {
                empleadoQuery = empleadoQuery.Where(x => reg.Apellidos == x.ApellidoEmpleado);
            }
            if (!string.IsNullOrEmpty(reg.Celda))
            {
                empleadoQuery = empleadoQuery.Where(x => int.Parse(reg.Celda) == x.CeldaId);
            }
            if (!string.IsNullOrEmpty(reg.Linea))
            {
                empleadoQuery = empleadoQuery.Where(x => int.Parse(reg.Linea) == x.LineaId);
            }
            if (!string.IsNullOrEmpty(reg.Celda))
            {
                empleadoQuery = empleadoQuery.Where(x => int.Parse(reg.Celda) == x.CeldaId);
            }
            if (!string.IsNullOrEmpty(reg.Centro))
            {
                empleadoQuery = empleadoQuery.Where(x => int.Parse(reg.Centro) == x.CentroId);
            }

            var listaEmpleados = empleadoQuery.ToList();
           
            var customRegs = new List<CustomReg>();

            foreach (Empleado empleado in listaEmpleados)
            {
                CustomReg customReg = new CustomReg();
                var listaRegs = await _serviceRegistro.FindWhere(x=> x.EmpleadoId == empleado.Id);

                if (reg.Finalizado) {
                    listaRegs = listaRegs.Where(x => x.Status == 2);
                }

                if (listaRegs.Count() > 0) {
                    var cel = await _serviceCelda.GetById(empleado.CeldaId);
                    var lin = await _serviceLinea.GetById(empleado.LineaId);
                    var registro = listaRegs.FirstOrDefault();

                    if (!string.IsNullOrEmpty(reg.TipoSalida) || !string.IsNullOrEmpty(reg.SectorEmpresaDestino))
                    {
                        if (registro.DatosSalidaId != null)
                        {
                            var listDatoSalida = await _serviceDatoSalida.FindWhere(x => x.DatoSalidaId == registro.DatosSalidaId);
                            if (!string.IsNullOrEmpty(reg.TipoSalida))
                            {
                                listDatoSalida = listDatoSalida.Where(x => x.TipoSalidaId == int.Parse(reg.TipoSalida));
                            }

                            if (!string.IsNullOrEmpty(reg.SectorEmpresaDestino ))
                            {
                                listDatoSalida = listDatoSalida.Where(x => x.SectorEmpresaDestinoId == int.Parse(reg.SectorEmpresaDestino));
                            }

                            var datoSalida = listDatoSalida.FirstOrDefault();

                            if (datoSalida != default(DatoSalida))
                            {
                                customReg.FechaSalida = datoSalida.FechaBaja;
                                customReg.Nombre = empleado.NombreEmpleado;
                                customReg.Numempleado = empleado.NumEmpleado;
                                customReg.Apellidos = empleado.ApellidoEmpleado;
                                customReg.Celda = cel.NombreCelda;
                                customReg.Linea = lin.NombreLinea;

                                customRegs.Add(customReg);
                            }
                        }
                    }
                    else {

                        var listDatoSalida = await _serviceDatoSalida.FindWhere(x => x.DatoSalidaId == registro.DatosSalidaId);

                        if (listDatoSalida.Count() > 0) {
                            var datoSalida = await _serviceDatoSalida.GetById(registro.DatosSalidaId.Value);
                            customReg.FechaSalida = datoSalida.FechaBaja;
                        }
                        
                        
                        customReg.Nombre = empleado.NombreEmpleado;
                        customReg.Numempleado = empleado.NumEmpleado;
                        customReg.Apellidos = empleado.ApellidoEmpleado;
                        customReg.Celda = cel.NombreCelda;
                        customReg.Linea = lin.NombreLinea;

                        customRegs.Add(customReg);
                    }
                }

            }
            


            return Ok(customRegs);

        }

    }
}