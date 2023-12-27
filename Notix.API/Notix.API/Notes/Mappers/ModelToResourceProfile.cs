using AutoMapper;
using Notix.API.Notes.Domain.Models;
using Notix.API.Notes.Resources.Show.Note;

namespace Notix.API.Notes.Mappers;

public class ModelToResourceProfile : Profile
{
    public ModelToResourceProfile()
    {
        CreateMap<Note, NoteResource>();
    }
}