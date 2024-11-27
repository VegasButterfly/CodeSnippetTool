using CodeSnippetTool.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSnippetTool.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Role> Roles { get; set; } = null!;
        public DbSet<Language> Languages { get; set; } = null!;
        public DbSet<Snippet> Snippets { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=AppData.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
        .HasMany(u => u.Roles)
        .WithMany(r => r.Users)
        .UsingEntity(j => j.ToTable("UserRoles"));

            modelBuilder.Entity<Role>()
                .Property(r => r.RoleName)
                .IsRequired();

            modelBuilder.Entity<Snippet>()
    .HasOne(s => s.CreatedBy)
    .WithMany(u => u.Snippets)
    .HasForeignKey(s => s.CreatedById)
    .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Snippet>()
                .HasOne(s => s.ReviewedBy)
                .WithMany()
                .HasForeignKey(s => s.ReviewedById)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Snippet>()
                .Property(s => s.IsDeleted)
                .HasDefaultValue(false);

            modelBuilder.Entity<Snippet>()
              .HasQueryFilter(s => !s.IsDeleted);

            modelBuilder.Entity<Role>()
                .Property(r => r.RoleName)
                .IsRequired();

            modelBuilder.Entity<Snippet>()
                .HasOne(s => s.Language)
                .WithMany()
                .HasForeignKey(s => s.LanguageId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Snippet>()
               .Property(s => s.CreatedDate)
               .HasDefaultValueSql("CURRENT_TIMESTAMP");

            modelBuilder.Entity<Snippet>()
                .Property(s => s.ReviewedDate)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");
        }

    }
}
