using Notix.API.Notes.Domain.Models;
using Notix.API.Shared.Domain.Service.Communication;

namespace Notix.API.Notes.Resources.Communication;

public class NoteResponse : BaseResponse<Note>
{
    public NoteResponse(Note resource) : base(resource)
    {
    }

    public NoteResponse(string message) : base(message)
    {
    }
}