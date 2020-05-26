using Microsoft.EntityFrameworkCore;
using ProjVendas.Models;
using ProjVendasWebMvc.Models;

namespace ProjVendas.Data
{
    public class ProjVendasContext : DbContext
    {
        public ProjVendasContext(DbContextOptions<ProjVendasContext> options)
            : base(options)
        {
        }

        public DbSet<Departamento> Departamento { get; set; }
        public DbSet<Vendedor> Vendedor { get; set; }
        public DbSet<HistoricoVendas> HistoricoVendas { get; set; }
    }
}
