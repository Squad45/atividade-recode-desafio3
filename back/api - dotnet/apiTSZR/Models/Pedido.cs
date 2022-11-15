using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiTSZR.Models
{
    [Table("pedido")]
    public class Pedido
    {
     [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
     [Key]
     public int Id { get; set; }

     [ForeignKey("avaliado")]
     public int AvaliacaoId { get; set; }

     
     public Avaliacao Avaliacao { get; set; }
     public Doacao Doacao { get; set; }
    }
}