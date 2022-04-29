using Microsoft.EntityFrameworkCore;

namespace DesafioMG.Models
{
    public class BancoDeDados : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Cliente> Livros { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=DESKTOP-NQUO750\SQLEXPRESS;Database=DesafioMG;Integrated Security=True");
        }
    }
}
