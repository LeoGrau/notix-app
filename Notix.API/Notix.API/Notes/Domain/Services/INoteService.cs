using Notix.API.Notes.Domain.Models;
using Notix.API.Notes.Resources.Communication;

namespace Notix.API.Notes.Domain.Services;

public interface INoteService
{
    Task<NoteResponse> FindAsync(long id);
    Task<NoteResponse> AddAsync(Note newNote);
    Task<IEnumerable<Note>> ListAllAsync();
}