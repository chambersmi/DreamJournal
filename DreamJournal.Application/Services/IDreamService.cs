using Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DreamJournal.Application.Services
{
    public interface IDreamService
    {
        Task<IEnumerable<DreamEntryDTO>> GetUserDreamsAsync(string userId);
        Task<DreamEntryDTO?> GetDreamByIdAsync(int id, string userId);
        Task<DreamEntryDTO> CreateDreamAsync(CreateDreamEntryDTO dto, string userId);
        Task<bool> DeleteDreamAsync(int id, string userId);
        Task<bool> UpdateDreamAsync(int id, DreamEntryDTO dto, string userId);
    }
}
