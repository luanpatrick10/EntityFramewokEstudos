using Microsoft.EntityFrameworkCore;

namespace EntityFramewokEstudos.Data
{
    public class ApplicationContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MyInstance;Integrated Security=true; ");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
