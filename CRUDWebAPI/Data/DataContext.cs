using CRUDWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDWebAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}

        public DbSet<Photo> Photos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Photo>()
                .HasData(
                    new Photo { Id = Guid.NewGuid(), Name = "Photo Description 1" },
                    new Photo { Id = Guid.NewGuid(), Name = "Photo Description 2" },
                    new Photo { Id = Guid.NewGuid(), Name = "Photo Description 3" }
                );
        }
    }
}
