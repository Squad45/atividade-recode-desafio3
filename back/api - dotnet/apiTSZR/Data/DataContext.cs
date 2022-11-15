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
        public DbSet<Endereco> Enderecos { get; set; }
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
        }
    }
}