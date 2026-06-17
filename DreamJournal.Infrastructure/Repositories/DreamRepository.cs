using DreamJournal.Domain.Entities;
using DreamJournal.Domain.Interfaces;
using DreamJournal.Infrastructure.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace DreamJournal.Infrastructure.Repositories
{
    public class DreamRepository : IDreamRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<DreamRepository> _logger;

        public DreamRepository(ApplicationDbContext context, ILogger<DreamRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<DreamEntity> AddAsync(DreamEntity dream)
        {

            await _context.DreamEntities.AddAsync(dream);
            await _context.SaveChangesAsync();

            return dream;            
        }

        public async Task<bool> DeleteAsync(int dreamEntityId, string userId)
        {
            var dream = await GetByIdAsync(dreamEntityId, userId);
            if(dream == null)
            {
                return false;
            }

            _context.DreamEntities.Remove(dream);

            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<DreamEntity>> GetAllByUserIdAsync(string userId)
        {
            return await _context.DreamEntities
                .Include(d => d.Song)
                .AsNoTracking()
                .Where(d => d.UserId == userId)
                .OrderByDescending(d => d.DreamDate)
                .ToListAsync();
        }

        public async Task<DreamEntity?> GetByIdAsync(int dreamEntityId, string userId)
        {
            return await _context.DreamEntities
                .Include(d => d.Song)
                .FirstOrDefaultAsync(d => d.DreamEntityId == dreamEntityId && d.UserId == userId);
        }

        public async Task<bool> UpdateAsync(DreamEntity dream)
        {
            _context.Entry(dream).State = EntityState.Modified;
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
