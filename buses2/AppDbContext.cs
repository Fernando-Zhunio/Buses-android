using Microsoft.EntityFrameworkCore;
using buses2.Models;
namespace buses2
{
    public class AppDbContext: DbContext
    {
        DbSet<Bus> bus { get; set; };
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        

        }
    }
}
