using Notix.API.Notes.Domain.Models;
using Notix.API.Shared.Domain.Repositories;

namespace Notix.API.Notes.Domain.Repositories;

public interface INoteRepository : IBaseRepository<Note, long>
{
    Task<IEnumerable<Note>> ListAllAsync();
}