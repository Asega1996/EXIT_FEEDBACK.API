
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExitFeedback.Models.Entities
{
    public class Status
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }

        [Column("STATUS")]
        public string Name { get; set; }

    }
}
