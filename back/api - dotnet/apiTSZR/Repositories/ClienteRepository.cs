using System.Security.Cryptography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiTSZR.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
         private readonly DataContext _context;

        public ClienteRepository(DataContext context)
        {
            _context = context;
        }
        public bool ClienteExist(int id)
        {
            return _context.Clientes.Any(c => c.Id == id);
        }
        public bool ClienteFisicoExist(string cpf)
        {
            return _context.Clientes.Any(c => c.Cpf == cpf);
        }
        public bool ClienteJuridicoExist(string cnpj)
        {
            return _context.Clientes.Any(c => c.Cnpj == cnpj);
        }

        public bool CreateCliente(Cliente cliente)
        {
            _context.Add(cliente);
            return Save();
        }

        public bool DeleteCliente(Cliente cliente)
        {
            _context.Remove(cliente);
            return Save();
        }

        public Cliente GetCliente(int id)
        {
            return _context.Clientes.Where(c => c.Id == id).FirstOrDefault();
        }

        public Cliente GetClienteByCNPJ(string cnpj)
        {
            return _context.Clientes.Where(c => c.Cnpj == cnpj).FirstOrDefault();
        }

        public Cliente GetClienteByCPF(string cpf)
        {
            return _context.Clientes.Where(c => c.Cpf == cpf).FirstOrDefault();
        }

        public ICollection<Cliente> GetClientes()
        {
            return _context.Clientes.OrderBy(c => c.Id).ToList();
        }


        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }
    }
}