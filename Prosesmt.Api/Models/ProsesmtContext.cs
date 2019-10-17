using Microsoft.EntityFrameworkCore;

namespace Prosesmt.Api.Models
{
    public class ProsesmtContext : DbContext
    {
        public ProsesmtContext(DbContextOptions<ProsesmtContext> options):base(options)
        {

        }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Chamado> Chamados { get; set; }
    }
}
