using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiTSZR.Models
{
    public class Disponivel
    {
        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        
        [ForeignKey("equipamento_disponivel")]
        public int EquipamentoId { get; set; }

        
        public Equipamento Equipamento { get; set; }
        public Doacao Doacao { get; set; }
    }
}