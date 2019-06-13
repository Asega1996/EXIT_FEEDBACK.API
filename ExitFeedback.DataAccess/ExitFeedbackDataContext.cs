using ExitFeedback.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExitFeedback.DataAccess
{
    public class ExitFeedbackDataContext : DbContext
    {
        public ExitFeedbackDataContext(DbContextOptions<ExitFeedbackDataContext> options) : base(options) { }

        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<DatoEmpleado> DatoEmpleados { get; set; }
        public DbSet<Registro> Registros { get; set; }
        public DbSet<Carrera> Carreras { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Centro> Centros { get; set; }
        public DbSet<Celda> Celdas { get; set; }
        public DbSet<DatoCalificacion> DatoCalificaciones { get; set; }
        public DbSet<DatoEntrevista> DatoEntrevistas { get; set; }
        public DbSet<DatoSalida> DatoSalidas { get; set; }
        public DbSet<Linea> Lineas { get; set; }
        public DbSet<MotivoSalida> MotivoSalidas { get; set; }
        public DbSet<Proyecto> Proyectos { get; set; }
        public DbSet<Sector> Sectores { get; set; }
        public DbSet<Tecnologia> Tecnologias { get; set; }
        public DbSet<TiempoEnProyecto> TiempoEnProyectos { get; set; }
        public DbSet<TipoBusqueda> TipoBusquedas { get; set; }
        public DbSet<TipoEmpresa> TipoEmpresas { get; set; }
        public DbSet<TipoSalida> TipoSalidas { get; set; }
        public DbSet<Titulacion> Titulaciones { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<IncrementoSalarial> IncrementoSalariales { get; set; }
        public DbSet<SubmotivoSalida> SubmotivoSalidas { get; set; }

    }
}
