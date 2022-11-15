using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiTSZR.Models
{
    public class Doacao
    {
        public int Id { get; set; }
        public Pedido Pedido { get; set; }
        public Disponivel Equipamento { get; set; }
    }
}