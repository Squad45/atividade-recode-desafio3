using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiTSZR.Models
{
    [Table("avaliacoes")]
    public class Avaliacao
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        
        [ForeignKey("cliente")]
        public int ClienteId { get; set;}

        [Column("avaliacao", TypeName = "VARCHAR(3)")]
        public string Avaliar { get; set; }
        
        
        public Cliente Cliente { get; set; }
    }
}