using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiTSZR.Models
{
    [Table("Enderecos")]
    public class Endereco
    {   
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        [Column("uf", TypeName = "VARCHAR(2)")]
        public string Uf { get; set; }

        [Column("cep", TypeName = "VARCHAR(8)")]
        public string Cep { get; set; }

        [Column("endereco", TypeName = "VARCHAR(150)")]
        public string Rua { get; set; }

        [Column("ponto_referencia", TypeName = "VARCHAR(70)")]
        public string PontoRef { get; set; }


        public Cliente cliente { get; set; }

    }
}