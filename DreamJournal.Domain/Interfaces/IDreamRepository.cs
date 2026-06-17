using DreamJournal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DreamJournal.Domain.Interfaces
{
    public interface IDreamRepository
    {
        Task<IEnumerable<DreamEntity>> GetAllByUserIdAsync(string userId);
        Task<DreamEntity?> GetByIdAsync(int dreamEntityId, string userId);
        Task<DreamEntity> AddAsync(DreamEntity dream);
        Task<bool> UpdateAsync(DreamEntity dream);
        Task<bool> DeleteAsync(int dreamEntityId, string userId);
    }
}
