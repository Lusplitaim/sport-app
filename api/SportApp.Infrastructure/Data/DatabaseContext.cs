using SportApp.Core.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace SportApp.Infrastructure.Data
{
    internal class DatabaseContext : DbContext
    {
        public DbSet<ExerciseEntity> Exercises { get; set; }
        public DbSet<ExerciseTypeEntity> ExerciseTypes { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ExerciseEntity>(b =>
            {
                b.HasKey(e => e.Id);
                b.HasOne<ExerciseTypeEntity>().WithMany()
                    .HasForeignKey(e => e.TypeId);
            });

            builder.Entity<ExerciseTypeEntity>(b =>
            {
                b.HasKey(e => e.Id);
                b.Property(e => e.Name).HasMaxLength(200);
                b.HasIndex(e => e.Name).IsUnique();
            });
        }
    }
}
