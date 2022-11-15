using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiTSZR.Interfaces
{
    public interface IClienteRepository
    {
        ICollection<Cliente> GetClientes();
        Cliente GetCliente(int id);
        bool ClienteFisicoExist(string cpf);
        bool ClienteJuridicoExist(string cnpj);
        Cliente GetClienteByCPF(string cpf);
        Cliente GetClienteByCNPJ(string cnpj);
        bool ClienteExist(int id);

        bool CreateCliente(Cliente cliente);
        bool DeleteCliente(Cliente cliente);
        bool Save();
    }
}