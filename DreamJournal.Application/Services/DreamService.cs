using DreamJournal.Domain.Entities;
using DreamJournal.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DreamJournal.Application.Services
{
    public class DreamService : IDreamService
    {
        private readonly IDreamRepository _dreamRepository;
        private readonly ILogger<DreamService> _logger;

        public DreamService(IDreamRepository dreamRepository, ILogger<DreamService> logger)
        {
            _dreamRepository = dreamRepository;
            _logger = logger;
        }

        public async Task<DreamEntryDTO> CreateDreamAsync(CreateDreamEntryDTO dto, string userId)
        {
            var entity = new DreamEntity
            {
                UserId = userId,
                DreamDate = dto.DreamDate,
                Title = dto.Title,
                Subject = dto.Subject,
                NotablePeople = dto.NotablePeople,
                DreamMood = dto.DreamMood,
                Description = dto.Description,
                SongReferenceId = dto.SongReferenceId,
            };

            var savedEntity = await _dreamRepository.AddAsync(entity);

            return new DreamEntryDTO(savedEntity.DreamEntityId, savedEntity.UserId, savedEntity.DreamDate, savedEntity.Title,
                savedEntity.Subject, savedEntity.NotablePeople, savedEntity.DreamMood, savedEntity.Description,
                savedEntity.SongReferenceId, null);

        }

        public Task<bool> DeleteDreamAsync(int id, string userId)
        {
            throw new NotImplementedException();
        }

        public Task<DreamEntryDTO?> GetDreamByIdAsync(int id, string userId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<DreamEntryDTO>> GetUserDreamsAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateDreamAsync(int id, DreamEntryDTO dto, string userId)
        {
            var existingEntry = await _dreamRepository.GetByIdAsync(id, userId);
            if (existingEntry == null) return false;

            existingEntry.Title = dto.Title;
            existingEntry.DreamDate = dto.DreamDate;
            existingEntry.Subject = dto.Subject;
            existingEntry.NotablePeople = dto.NotablePeople;
            existingEntry.DreamMood = dto.DreamMood;
            existingEntry.Description = dto.Description;
            existingEntry.SongReferenceId = dto.SongReferenceId;

            return await _dreamRepository.UpdateAsync(existingEntry);
        }
    }
}
