using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiTSZR.Dto
{
    public class ClienteDtoFisica
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string? Cpf { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Escolha { get; set; }
        public string? Equipamento { get; set; }
        public string Explicacao { get; set; }
        public Endereco Endereco { get; set; }
    }
}