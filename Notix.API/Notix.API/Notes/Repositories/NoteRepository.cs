using Microsoft.EntityFrameworkCore;
using Notix.API.Notes.Domain.Models;
using Notix.API.Notes.Domain.Repositories;
using Notix.API.Shared.Persistence;
using Notix.API.Shared.Persistence.Repositories;

namespace Notix.API.Notes.Repositories;

public class NoteRepository : BaseRepository<Note, long>, INoteRepository
{
    public NoteRepository(AppDbContext appDbContext) : base(appDbContext)
    {
    }

    public async Task<IEnumerable<Note>> ListAllAsync()
    {
        return await Entities.ToListAsync();
    }
}