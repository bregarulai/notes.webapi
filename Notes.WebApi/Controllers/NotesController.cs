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

        [HttpPost]
        public IActionResult CreateNote(Note note)
        {
            _logger.LogInformation("Note created");
            return Ok(_notesServices.CreateNote(note));
        }
    }
}
