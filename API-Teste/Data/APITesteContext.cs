using API_Teste.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Teste.Data
{
    public class APITesteContext : DbContext
    {
        public APITesteContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
    }
}
