using DreamJournal.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Shared.DTOs
{
    public record CreateDreamEntryDTO
    {
        [Required(ErrorMessage = "Please select the date of the dream.")]
        public DateTime DreamDate { get; set; } = DateTime.Today;

        [Required(ErrorMessage = "Your dream needs a descriptie title.")]
        [StringLength(100, ErrorMessage = "Keep the title under 100 characters.")]

        public string? Subject { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? NotablePeople { get; set; }

        [Required(ErrorMessage = "Please select the overall mood of the dream.")]
        public DreamMoodEnum DreamMood { get; set; }

        public string? Description { get; set; }
        public int? SongReferenceId { get; set; }
    }
}
