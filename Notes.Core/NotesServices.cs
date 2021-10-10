using Notes.Db;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public Note GetNote(int id)
        {
            return _context.Notes.FirstOrDefault(e => e.Id == id);
        }

        public List<Note> GetNotes()
        {
            return _context.Notes.ToList();
        }
    }
}
