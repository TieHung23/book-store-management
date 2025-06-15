using bsm.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace bsm.Infrastructure.Data
{
    public class DataContext : DbContext
    {
        public DataContext( DbContextOptions<DataContext> options )
            : base( options )
        {
        }

        public DbSet<User> Users { get; set; } = null!;
    }
}
