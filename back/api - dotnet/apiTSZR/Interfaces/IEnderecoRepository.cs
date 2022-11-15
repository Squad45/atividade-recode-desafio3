using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiTSZR.Interfaces
{
    public interface IEnderecoRepository
    {
        ICollection<Endereco> GetEnderecos();
        Endereco GetEndereco(string cep, string uf);
        bool CreateEndereco( Endereco endereco);
        bool Save();
    }
}