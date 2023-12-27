using System.Net.Mime;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Notix.API.Notes.Domain.Models;
using Notix.API.Notes.Domain.Services;
using Notix.API.Notes.Resources.Show.Note;
using Swashbuckle.AspNetCore.Annotations;

namespace Notix.API.Notes.Controllers.Rest.API;

[ApiController]
[Route("api/v1/[controller]")]
[Produces(MediaTypeNames.Application.Json)]
[SwaggerTag("Controller for Banks")]
public class NoteController : ControllerBase
{
    private INoteService _noteService;
    private IMapper _mapper;

    public NoteController(INoteService noteService, IMapper mapper)
    {
        _noteService = noteService;
        _mapper = mapper;
    }

    [HttpGet("get/{id}")]
    public async Task<IActionResult> GetNoteById(long id)
    {
        var result = await _noteService.FindAsync(id);
        if (!result.Success)
            return BadRequest();
        var mappedResource = _mapper.Map<Note, NoteResource>(result.Resource!);
        return Ok(mappedResource);
    }
    [HttpGet("all")]
    public async Task<IEnumerable<Note>> ListNotes()
    {
        return await _noteService.ListAllAsync();
    }


}