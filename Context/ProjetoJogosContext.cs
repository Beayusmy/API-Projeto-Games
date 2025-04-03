using Microsoft.EntityFrameworkCore;
using ProjetoDeJogos.Domains;

namespace ProjetoDeJogos.Context
{
    public class ProjetoJogosContext : DbContext
    {
       public ProjetoJogosContext() {}

        public ProjetoJogosContext(DbContextOptions<ProjetoJogosContext>options): base(options) 
        {

        }

        public DbSet<Jogo> jogos { get; set; }
        public DbSet<Usuario>  Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=NOTE04-S28\\SQLEXPRESS; Database=Jogos; user Id = sa; pwd=Senai@134; TrustServerCertificate=true;");
            }

        }
       
    }
}
