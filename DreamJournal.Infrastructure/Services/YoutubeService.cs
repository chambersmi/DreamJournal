using DreamJournal.Application.Interfaces;
using DreamJournal.Application.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DreamJournal.Infrastructure.Services
{
    public class YoutubeService : IYoutubeService
    {
        public Task<List<SongSearchResult>> SearchSongAsync(string searchTerm)
        {
            throw new NotImplementedException();
        }
    }
}
