using System;
using System.Collections.Generic;

namespace winfroms_note_taking.Models;

public partial class Note
{
    public int NoteId { get; set; }

    public int? UserId { get; set; }

    public string Title { get; set; } = null!;

    public string Content { get; set; } = null!;

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual ICollection<NoteTag> NoteTags { get; set; } = new List<NoteTag>();

    public virtual User? User { get; set; }
}
