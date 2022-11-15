using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiTSZR.Repositories
{
    public class EnderecoRepository : IEnderecoRepository
    {
         private readonly DataContext _context;

        public EnderecoRepository(DataContext context)
        {
            _context = context;
        }
        public bool CreateEndereco(Endereco endereco)
        {
            _context.Add(endereco);
            return Save();
        }

        public Endereco GetEndereco(string cep, string uf)
        {
            return _context.Enderecos.Where(e => e.Cep == cep && e.Uf == uf).FirstOrDefault();
        }

        public ICollection<Endereco> GetEnderecos()
        {
            return _context.Enderecos.ToList();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }
    }
}