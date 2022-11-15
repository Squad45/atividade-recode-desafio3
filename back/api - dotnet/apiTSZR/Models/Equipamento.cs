using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiTSZR.Models
{
    public class Equipamento
    {
        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        [ForeignKey("equipamento_avaliado")]
        public int AvaliacaoId { get; set; }

        [ForeignKey("loja_responsavel")]
        public int TecId { get; set; }

        [Column("pecas", TypeName = "VARCHAR(80)")]
        public string Pecas { get; set;}

        [Column("valor", TypeName = "DECIMAL(10,2)")]
        public double Valor { get; set; }

       
        public Avaliacao Avaliacao { get; set;}
        public AssistenciaTec Tec { get; set; }
    }
}