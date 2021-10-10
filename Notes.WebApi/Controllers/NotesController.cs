using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Notes.Core;
using Notes.Db;

namespace Notes.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NotesController : ControllerBase
    {
       
        private readonly ILogger<NotesController> _logger;

        private readonly INoteServices _notesServices;

        public NotesController(ILogger<NotesController> logger, INoteServices notesServices)
        {
            _logger = logger;
            _notesServices = notesServices;
        }

        [HttpGet]
        public IActionResult GetNotes()
        {
            _logger.LogInformation("Returned all notes");
            return Ok(_notesServices.GetNotes());
        }

        [HttpGet("{id}", Name = "GetNote")]
        public IActionResult GetNote(int id)
        {
            _logger.LogInformation("Note returned");
            return Ok(_notesServices.GetNote(id));
        }

        [HttpPost]
        public IActionResult CreateNote(Note note)
        {
            var newNote = _notesServices.CreateNote(note);
            _logger.LogInformation("Note created");
            return CreatedAtRoute("GetNote", new { newNote.Id }, newNote);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteNote(int id)
        {
            _logger.LogInformation("Note deleted");
            _notesServices.DeleteNote(id);
            return Ok();
        }
    }
}
