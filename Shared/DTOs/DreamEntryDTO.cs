using DreamJournal.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.DTOs
{
    public record DreamEntryDTO(
        int DreamEntityId,
        string UserId,
        DateTime DreamDate,
        string Title,
        string? Subject,
        string? NotablePeople,
        DreamMoodEnum DreamMood,
        string? Description,
        int? SongReferenceId,
        string? AssociatedSongTitle
);
}