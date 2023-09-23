using Microsoft.EntityFrameworkCore;
using WebApplicationForMAUI.Class;

namespace WebApplicationForMAUI.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Usuario> Usuario { get; set; }
    }
}
