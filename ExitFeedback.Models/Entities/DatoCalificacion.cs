using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ExitFeedback.Models.Entities
{
    [Table("DATO_CALIFICACION")]
    public class DatoCalificacion : BaseEntity
    {
        [Key]
        [Column("DATO_CALIFICACION_ID")]
        public int DatoCalificacionId { get; set; }
        [Column("PROCESO_SELECCION_NOTA")]
        public int ProcesoSeleccionNota { get; set; }
        [Column("PROCESO_SELECCION_COMENTARIO")]
        public string ProcesoSeleccionComentario { get; set; }
        [Column("INTEGRACION_NOTA")]
        public int IntegracionNota { get; set; }
        [Column("INTEGRACION_COMENTARIO")]
        public string IntegracionComentario { get; set; }
        [Column("TUTOR_NOTA")]
        public int TutorNota { get; set; }
        [Column("TUTOR_COMENTARIO")]
        public string TutorComentario { get; set; }
        [Column("RETRIBUCION_NOTA")]
        public int RetribucionNota { get; set; }
        [Column("RETRIBUCION_COMENTARIO")]
        public string RetribucionComentario { get; set; }
        [Column("HORARIO_NOTA")]
        public int HorarioNota { get; set; }
        [Column("HORARIO_COMENTARIO")]
        public string HorarioComentario { get; set; }
        [Column("FORMACION_NOTA")]
        public int FormacionNota { get; set; }
        [Column("FORMACION_COMENTARIO")]
        public string FormacionComentario { get; set; }
        [Column("SUPERVISORES_NOTA")]
        public int SupervisoresNota { get; set; }
        [Column("SUPERVISORES_COMENTARIO")]
        public string SupervisoresComentario { get; set; }
        [Column("COMUNICACION_INTERNA_NOTA")]
        public int ComunicacionInternaNota { get; set; }
        [Column("COMUNICACION_INTERNA_COMENTARIO")]
        public string ComunicacionInternComentario { get; set; }
    }
}
