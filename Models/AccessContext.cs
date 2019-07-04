using Microsoft.EntityFrameworkCore;

namespace AccessDetect.Models
{
    public class AccessContext : DbContext
    {
        public DbSet<Access> Access { get; set; }

        public AccessContext(DbContextOptions<AccessContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new AccessMap(modelBuilder.Entity<Access>());
        }

    }   
}
