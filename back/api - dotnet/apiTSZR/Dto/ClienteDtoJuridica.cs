using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiTSZR.Dto
{
    public class ClienteDtoJuridica
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string? Cnpj { get; set; }
        public string? Cargo { get; set; }
        public string? Instituicao { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Escolha { get; set; }
        public string? Equipamento { get; set; }
        public string Explicacao { get; set; }
        public string Uf { get; set; }

        public string Cep { get; set; }

        public string Rua { get; set; }

        public string PontoRef { get; set; }
    }
}