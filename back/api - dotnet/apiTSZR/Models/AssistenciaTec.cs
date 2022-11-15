using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiTSZR.Models
{
    public class AssistenciaTec
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        [Column("loja", TypeName = "VARCHAR(80)")]
        public string Loja { get; set; }

        
        public ICollection<Equipamento> Equipamentos { get; set; }
    }
}