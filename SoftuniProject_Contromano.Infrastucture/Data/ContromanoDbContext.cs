using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SoftuniProject_Contromano.Infrastucture.Data.Models;


namespace SoftuniProject_Contromano.Infrastucture.Data
{
    public class ContromanoDbContext : IdentityDbContext
    {
        public ContromanoDbContext(DbContextOptions<ContromanoDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<IdentityUserLogin<string>>()
                .HasKey(ul => new { ul.LoginProvider, ul.ProviderKey });
            modelBuilder.Entity<Category>()
                                .HasMany(c => c.Articles)
                .WithOne(a => a.Category)
                .HasForeignKey(a => a.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>()
                .HasData
                (new Category { Id = 1, Name = "Centro Estivo" },
                 new Category { Id = 2, Name = "Estate Rover 23" },
                 new Category { Id = 3, Name = "Ciclofficina itinerante" },
                 new Category { Id = 4, Name = "Scout" },
                 new Category { Id = 5, Name = "Rotobike" }
            );
        }

        public DbSet<Article> Articles { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Comment> Comments { get; set; } = null!;

    }
}
