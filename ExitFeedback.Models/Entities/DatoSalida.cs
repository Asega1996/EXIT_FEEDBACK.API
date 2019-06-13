using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExitFeedback.Models.Entities
{
    [Table("DATO_SALIDA")]
    public class DatoSalida : BaseEntity
    {
        [Key]
        [Column("DATOS_SALIDA_ID")]
        public int DatoSalidaId { get; set; }
        [Column("TIPO_SALIDA_ID")]
        public int TipoSalidaId { get; set; }
        [Column("MOTIVO_SALIDA_1")]
        public int MotivoSalida1 { get; set; }
        [Column("SUB_MOTIVO_1")]
        public int SubMotivo1 { get; set; }
        [Column("MOTIVO_SALIDA_2")]
        public int MotivoSalida2 { get; set; }
        [Column("SUB_MOTIVO_2")]
        public int SubMotivo2 { get; set; }
        [Column("TIPO_BUSQUEDA_ID")]
        public int TipoBusquedaId { get; set; }
        [Column("SECTOR_EMPRESA_DESTINO_ID")]
        public int SectorEmpresaDestinoId { get; set; }
        [Column("TIPO_EMPRESA_DESTINO_ID")]
        public int TipoEmpresaDestinoId { get; set; }
        [Column("EMPRESA_DESTINO")]
        public string EmpresaDestino { get; set; }
        [Column("INCREMENTO_SALARIAL")]
        public int IncrementoSalarial { get; set; }
        [Column("NUEVO_PUESTO")]
        public string NuevoPuesto { get; set; }
        [Column("UBICACION")]
        public string Ubicacion { get; set; }
        [Column("OBSERVACIONES_NUEVO_EMPLEO")]
        public string ObservacionesNuevoEmpleo { get; set; }
        [Column("FECHA_BAJA")]
        public DateTime FechaBaja { get; set; }
    }
}
