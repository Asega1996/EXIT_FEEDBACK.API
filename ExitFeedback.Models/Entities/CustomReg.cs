using System;
using System.Collections.Generic;
using System.Text;

namespace ExitFeedback.Models.Entities
{
    public class CustomReg: BaseEntity
    {
        public int Numempleado;
        public string Nombre;
        public string Apellidos;
        public string Celda;
        public string Linea;
        public DateTime FechaSalida;
        public string Centro;
        public bool Finalizado;
        public string TipoSalida;
        public string SectorEmpresaDestino;
    }
}
