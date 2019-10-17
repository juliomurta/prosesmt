
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prosesmt.Api.Models
{
    public class Chamado
    {
        [Key]
        public long Id { get; set; }

        public Cliente Cliente { get; set; }

        [Required]
        [Column("DataHora_Abertura", TypeName = "datetime")]
        public DateTime Abertura { get; set; }

        [Required]
        [Column("Fechado", TypeName = "bit")]
        public bool IsFechado { get; set; }

        [Column("DataHora_Fechamento", TypeName = "datetime")]
        public DateTime Fechamento { get; set; }
    }
}
