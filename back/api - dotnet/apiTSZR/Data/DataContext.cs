using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace apiTSZR.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Avaliacao> Avaliacoes { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Equipamento> Equipamentos { get; set; }
        public DbSet<AssistenciaTec> AssistenciaTecs { get; set; }
        public DbSet<Disponivel> Disponiveis { get; set; }
        public DbSet<Doacao> Doacoes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //seeding de dados
            modelBuilder.Entity<AssistenciaTec>().HasData(
                new AssistenciaTec
                {
                    Id = 1,
                    Loja = "Remakker"
                },
                new AssistenciaTec
                {
                    Id = 2,
                    Loja = "Recuperador Tecnologia"
                },
                new AssistenciaTec
                {
                    Id = 3,
                    Loja = "Cell Week"
                }

            );
            modelBuilder.Entity<Cliente>().HasData(
                new Cliente
                {
                    Id = 1,
                    Nome = "Roberto Silva",
                    Cpf = "33344433321",
                    Email = "robertSil@gmail.com",
                    Telefone = "11987435467",
                    Escolha = "beneficio",
                    Explicacao = "preciso porque sou estudante",
                    Uf = "SP",
                    Cep = "23430654",
                    Rua = "Rua das Flores",
                    PontoRef = "mercearia do Jorge"
                },
                new Cliente
                {
                    Id = 2,
                    Nome = "Fracisco Wallace",
                    Cnpj = "11222111222133",
                    Cargo = "Gerente",
                    Instituicao = "Hospital Nogueira",
                    Email = "wallacetrab@hotmail.com",
                    Telefone = "21987224351",
                    Escolha = "doador",
                    Equipamento = "Computador",
                    Explicacao = "estou aqui para doar 2 computadores que não usamos mais",
                    Uf = "RJ",
                    Cep = "41264100",
                    Rua = "Av dos Alfaiates",
                    PontoRef = "Terminal Alfaiate"
                    
                }
            );
        }
    }
}