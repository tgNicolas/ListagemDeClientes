using ListagemDeClientes.Models;
using Microsoft.EntityFrameworkCore;

namespace ListagemDeClientes.DATA
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<UserAction> UserActions { get; set; }
    }
}
