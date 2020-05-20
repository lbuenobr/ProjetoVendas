using Microsoft.EntityFrameworkCore;

namespace ProjVendas.Data
{
    public class ProjVendasContext : DbContext
    {
        public ProjVendasContext (DbContextOptions<ProjVendasContext> options)
            : base(options)
        {
        }

        public DbSet<ProjVendas.Models.Departamento> Departamento { get; set; }
    }
}
