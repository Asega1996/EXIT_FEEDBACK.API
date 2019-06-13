using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ExitFeedback.Models.Entities
{
    [Table("CATEGORIA")]
    public class Categoria : BaseEntity
    {
        [Key]
        [Column("CATEGORIA_ID")]
        public int CategoriaId { get; set; }
        [Column("NOMBRE_CATEGORIA")]
        public string NombreCategoria { get; set; }
    }
}
