using Notes.Db;
using System;
using System.Collections.Generic;
using System.Text;

namespace Notes.Core
{
    public interface INoteServices
    {
        Note CreateNote(Note note);
    }
}
