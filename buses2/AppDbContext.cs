using Microsoft.EntityFrameworkCore;
using buses2.Models;
namespace buses2
{
    public class AppDbContext: DbContext
    {
        public DbSet<Bus> bus { get; set; }
        DbSet<Driver> driver { get; set; }
        DbSet<User> user { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) { 
        

        }
    }
}
