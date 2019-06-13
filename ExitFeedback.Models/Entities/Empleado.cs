using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExitFeedback.Models.Entities
{
    [Table("EMPLEADO")]
    public class Empleado : BaseEntity
    {
        [Key]
        [Column("EMPLEADO_ID")]
        public int Id { get; set; }
        [Column("NUM_EMPLEADO")]
        public int NumEmpleado { get; set; }
        [Column("NOMBRE")]
        public string NombreEmpleado { get; set; }
        [Column("APELLIDOS")]
        public string ApellidoEmpleado { get; set; }
        [Column("CATEGORIA_ID")]
        public int CategoriaId { get; set; }
        [Column("LINEA_ID")]
        public int LineaId { get; set; }
        [Column("CELDA_ID")]
        public int CeldaId { get; set; }
        [Column("CENTRO_ID")]
        public int CentroId { get; set; }

    }
}
