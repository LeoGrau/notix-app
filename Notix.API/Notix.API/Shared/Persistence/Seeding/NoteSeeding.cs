using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Notix.API.Notes.Domain.Models;

namespace Notix.API.Shared.Persistence.Seeding;

public class NoteSeeding : IEntityTypeConfiguration<Note>
{
    public void Configure(EntityTypeBuilder<Note> builder)
    {
        builder.HasData(
            new Note
            {
                Id = 1,
                Title = "Testing",
                Description = "Lorem Ipsum must be forever."
            }, new Note
            {
                Id = 2,
                Title = "Testing 2",
                Description = "Lorem Ipsum must be forever 2."
            }, new Note
            {
                Id = 3,
                Title = "Testing 3",
                Description = "Lorem Ipsum must be forever 3."
            });
    }
}