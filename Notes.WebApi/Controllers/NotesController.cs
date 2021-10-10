using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace Notes.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NotesController : ControllerBase
    {
       
        private readonly ILogger<NotesController> _logger;

        public NotesController(ILogger<NotesController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public IActionResult CreateNote()
        {
            return Ok("My first notes");
        }
    }
}
