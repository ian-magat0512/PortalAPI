using Microsoft.EntityFrameworkCore;
using PortalAPI.Model;

namespace PortalAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Products> Products { get; set; }
    }
}
