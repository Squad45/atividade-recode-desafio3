using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiTSZR.Models
{
    public class Cliente
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        [Column("nome", TypeName = "VARCHAR(70)")]
        public string Nome { get; set; }

        [Column("cpf", TypeName = "VARCHAR(11)")]
        public string? Cpf { get; set; }

        [Column("cnpj", TypeName = "VARCHAR(14)")]
        public string? Cnpj { get; set; }

        [Column("cargo", TypeName = "VARCHAR(50)")]
        public string? Cargo { get; set; }

        [Column("instituicao", TypeName = "VARCHAR(50)")]
        public string? Instituicao { get; set; }

        [Column("email", TypeName = "VARCHAR(100)")]
        public string Email { get; set; }

        [Column("telefone", TypeName = "VARCHAR(11)")]
        public string Telefone { get; set; }

        [Column("escolha", TypeName = "VARCHAR(10)")]
        public string Escolha { get; set; }

        [Column("equipamento_doado", TypeName = "VARCHAR(10)")]
        public string? Equipamento { get; set; }

        [Column("texto_explicativo", TypeName = "VARCHAR(255)")]
        public string Explicacao { get; set; }

        [ForeignKey("endereco")]
        public int EnderecoId { get; set; }

        public Endereco Endereco { get; set; }
        public Avaliacao Avaliacao {get; set; }
    }
}