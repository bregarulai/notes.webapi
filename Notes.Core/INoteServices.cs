using Notes.Db;
using System;
using System.Collections.Generic;
using System.Text;

namespace Notes.Core
{
    public interface INoteServices
    {
        Note CreateNote(Note note);
        Note GetNote(int id);
        List<Note> GetNotes();
        void DeleteNote(int id);
    }
}
