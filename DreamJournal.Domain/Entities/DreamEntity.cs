using DreamJournal.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DreamJournal.Domain.Entities
{
    public class DreamEntity
    {
        public int DreamEntityId { get; set; }
        public string UserId { get; set; } = null!;
        public DateTime DreamDate { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Subject { get; set; }
        
        public string? NotablePeople { get; set; }
        public DreamMoodEnum DreamMood { get; set; }

        public string? Description { get; set; }
        public int? SongReferenceId { get; set; }
        public SongReference? SongReference { get; set; }

    }
}
