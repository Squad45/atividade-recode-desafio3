using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace apiTSZR.Models
{
    [Table("clientes")]
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

        [Column("escolha", TypeName = "VARCHAR(14)")]
        public string Escolha { get; set; }

        [Column("equipamento_doado", TypeName = "VARCHAR(10)")]
        public string? Equipamento { get; set; }

        [Column("texto_explicativo", TypeName = "VARCHAR(255)")]
        public string Explicacao { get; set; }

         [Column("uf", TypeName = "VARCHAR(2)")]
        public string Uf { get; set; }

        [Column("cep", TypeName = "VARCHAR(8)")]
        public string Cep { get; set; }

        [Column("endereco", TypeName = "VARCHAR(150)")]
        public string Rua { get; set; }

        [Column("ponto_referencia", TypeName = "VARCHAR(70)")]
        public string PontoRef { get; set; }

        [JsonIgnore]
        public Avaliacao Avaliacao {get; set; }
    }
}