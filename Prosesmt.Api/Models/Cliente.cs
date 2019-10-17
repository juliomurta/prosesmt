
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prosesmt.Api.Models
{
    public class Cliente
    {
        [Key]
        public long Id { get; set; }

        [Required]
        [Column("CNPJ_CPF", TypeName = "varchar(14)")]
        public string CnpjCpf { get; set; }

        [Required]
        [Column("RazaoSocial_Nome", TypeName = "varchar(60)")]
        public string RazaoSocial { get; set; }

        [Required]
        [Column("CEP", TypeName = "varchar(8)")]
        public string CEP { get; set; }

        [Required]
        [Column("Logradouro", TypeName = "varchar(60)")]
        public string Logradouro { get; set; }

        [Required]
        [Column("Logradouro_Numero", TypeName = "varchar(10)")]
        public string Numero { get; set; }

        [Required]
        [Column("Logradouro_Complemento", TypeName = "varchar(60)")]
        public string Complemento { get; set; }

        [Required]
        [Column("Logradouro_Bairro", TypeName = "varchar(60)")]
        public string Bairro { get; set; }

        [Required]
        [Column("Logradouro_Cidade", TypeName = "varchar(60)")]
        public string Cidade { get; set; }

        [Required]
        [Column("Logradouro_UF", TypeName = "varchar(2)")]
        public string UF { get; set; }

        [Column("Telefone", TypeName = "varchar(12)")]
        public string Telefone { get; set; }

        [Required]
        [Column("SLA_RespostaTempo", TypeName = "int")]
        public int SLARespostaTempo { get; set; }
    }
}
