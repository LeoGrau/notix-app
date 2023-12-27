using Notix.API.Notes.Domain.Models;
using Notix.API.Notes.Domain.Repositories;
using Notix.API.Notes.Domain.Services;
using Notix.API.Notes.Repositories;
using Notix.API.Notes.Resources.Communication;
using Notix.API.Shared.Domain.Repositories;

namespace Notix.API.Notes.Services;

public class NoteService : INoteService
{
    private INoteRepository _noteRepository;
    private readonly IUnitOfWork _unitOfWork;

    public NoteService(INoteRepository noteRepository, IUnitOfWork unitOfWork)
    {
        _noteRepository = noteRepository;
        _unitOfWork = unitOfWork;
    }

    public Task<NoteResponse> FindAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<NoteResponse> AddAsync(Note newNote)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Note>> ListAllAsync()
    {
        return await _noteRepository.ListAllAsync();
    }
}