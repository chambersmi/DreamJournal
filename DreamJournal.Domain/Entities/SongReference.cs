using System;
using System.Collections.Generic;
using System.Text;

namespace DreamJournal.Domain.Entities
{
    public class SongReference
    {
        public int SongReferenceId { get; set; }
        public string? YoutubeVideoId { get; set; }
        public string? Title { get; set; }
        public string? Artist { get; set; }
        public string? YoutubeUrl { get; set; }

        public List<DreamEntity> Dreams { get; set; } = [];
    }
}
