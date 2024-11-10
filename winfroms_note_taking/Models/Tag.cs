using System;
using System.Collections.Generic;

namespace winfroms_note_taking.Models;

public partial class Tag
{
    public int TagId { get; set; }

    public string TagName { get; set; } = null!;

    public virtual ICollection<NoteTag> NoteTags { get; set; } = new List<NoteTag>();
}
