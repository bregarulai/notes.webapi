using Notes.Db;
using System;

namespace Notes.Core
{
    public class NotesServices : INoteServices
    {
        private readonly AppDbContext _context;

        public NotesServices(AppDbContext context)
        {
            _context = context;
        }

        public Note CreateNote(Note note)
        {
            _context.Add(note);
            _context.SaveChanges();

            return note;
        }
    }
}
