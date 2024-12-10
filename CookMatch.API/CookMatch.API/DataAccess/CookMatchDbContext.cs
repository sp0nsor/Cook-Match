using CookMatch.API.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace CookMatch.API.DataAccess
{
    public class CookMatchDbContext : DbContext
    {
        public CookMatchDbContext(DbContextOptions<CookMatchDbContext> options)
            :base(options)
        {
        }

        public DbSet<RecipeEntity> Recipes { get; set; }
        public DbSet<IngredientEntity> Ingredients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RecipeEntity>()
                .HasMany(r => r.Ingredients)
                .WithOne()
                .HasForeignKey(i => i.recipeId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(modelBuilder);
        }
    }
}
