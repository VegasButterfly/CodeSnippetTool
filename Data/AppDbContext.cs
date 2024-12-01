using CodeSnippetTool.Models;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace CodeSnippetTool.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Role> Roles { get; set; } = null!;
        public DbSet<Language> Languages { get; set; } = null!;
        public DbSet<Snippet> Snippets { get; set; } = null!;
        public DbSet<Translation> Translations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {            
            optionsBuilder.UseSqlite("Data Source=AppData.db");
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // User-Roles 
            modelBuilder.Entity<User>()
                .HasOne(u => u.Role)
                .WithMany(r => r.Users)
                .HasForeignKey(u => u.RoleId)
                .OnDelete(DeleteBehavior.Restrict);

            // Role
            modelBuilder.Entity<Role>()
                .Property(r => r.RoleName)
                .IsRequired();

            modelBuilder.Entity<Role>()
                .HasIndex(r => r.RoleName)
                .IsUnique();

            // User
            modelBuilder.Entity<User>()
                .HasIndex(u => u.Username)
                .IsUnique();

            // Language
            modelBuilder.Entity<Language>()
                .Property(l => l.LanguageName)
                .IsRequired();
            modelBuilder.Entity<Language>()
                .HasIndex(l => l.LanguageName)
                .IsUnique();

            // Snippet Relationships
            modelBuilder.Entity<Snippet>()
              .HasOne(s => s.CreatedBy)
                .WithMany(u => u.Snippets)
                .HasForeignKey(s => s.CreatedById)
                .OnDelete(DeleteBehavior.SetNull);

           modelBuilder.Entity<Snippet>()
                .HasOne(s => s.ReviewedBy)
                .WithMany(u => u.ReviewedSnippets)
                .HasForeignKey(s => s.ReviewedById)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Snippet>()
                .HasMany(s => s.Translations)
                .WithOne(t => t.Snippet)
                .HasForeignKey(t => t.SnippetId);

            modelBuilder.Entity<Snippet>()
                .HasOne(s => s.Language)
                .WithMany(l => l.Snippets)    
                .HasForeignKey(s => s.LanguageId)
                .OnDelete(DeleteBehavior.SetNull);

            // Default Values and Filters
            modelBuilder.Entity<Snippet>()
                .Property(s => s.IsDeleted)
                .HasDefaultValue(false);

            modelBuilder.Entity<Snippet>()
                .HasQueryFilter(s => !s.IsDeleted);

            modelBuilder.Entity<Snippet>()
                .Property(s => s.CreatedDate)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            modelBuilder.Entity<Snippet>()
                .Property(s => s.ReviewedDate)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .IsRequired(false);
        }
    }
}