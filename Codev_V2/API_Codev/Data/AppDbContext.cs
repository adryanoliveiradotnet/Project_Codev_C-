

using Microsoft.EntityFrameworkCore;

using API_Codev.Models;

namespace API_Codev.Data

{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }
        public DbSet<User>Users { get; set; }
    }
}
