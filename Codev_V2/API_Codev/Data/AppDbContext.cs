using Microsoft.EntityFrameworkCore;
using API_Codev.Models;

namespace API_Codev.Data

{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<User>Users{ get; set; }
        public DbSet<Clientes>Clientes{ get; set; }
        public DbSet<Aparelhos>Aparelhos{ get; set; }
        public DbSet<Funcionários> Funcionários{ get; set; }
    }
}
