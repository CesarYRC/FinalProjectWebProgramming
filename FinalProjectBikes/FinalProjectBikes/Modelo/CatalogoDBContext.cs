using Microsoft.EntityFrameworkCore;

namespace FinalProjectBikes.Modelo
{
    public class CatalogoDBContext : DbContext
    {
        public CatalogoDBContext(DbContextOptions<CatalogoDBContext> options) : base(options)
        { 
        }
        public DbSet<Cliente> Cliente { get; set; }
    }
}
