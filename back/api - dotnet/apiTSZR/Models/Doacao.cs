using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiTSZR.Models
{
    public class Doacao
    {
        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        
        [ForeignKey("pedido")]
        public int PedidoId { get; set;}

        [ForeignKey("equipamento")]
        public int EquipamentoId { get; set; }

        
        public Pedido Pedido { get; set; }
        public Disponivel Equipamento { get; set; }
    }
}