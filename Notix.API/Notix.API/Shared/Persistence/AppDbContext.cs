using Microsoft.EntityFrameworkCore;
using Notix.API.Notes.Domain.Models;
using Notix.API.Shared.Extensions;
using Notix.API.Shared.Persistence.Seeding;

namespace Notix.API.Shared.Persistence;

public class AppDbContext : DbContext
{
    public DbSet<Note> Notes { get; set; }

    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Note>().ToTable("Notes");
        modelBuilder.Entity<Note>().HasKey(note => note.Id);
        modelBuilder.Entity<Note>().Property(note => note.Id);
        modelBuilder.Entity<Note>().Property(note => note.Title);
        modelBuilder.Entity<Note>().Property(note => note.Description);
        
        // Model Builder
        modelBuilder.ApplyConfiguration(new NoteSeeding());
        modelBuilder.ConvertAllToSnakeCase();
    }
}