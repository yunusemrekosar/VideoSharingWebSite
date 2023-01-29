using WebSite.Application.ITablesRepositories.IPlaylistRepository;
using WebSite.Domain.Entities;
using WebSite.Persistence.Context;
using WebSite.Persistence.Repositories;

namespace WebSite.Persistence.Concretes.PlaylistRepository
{
    public class PlaylistWrite : WriteRepository<Playlist>, IPlaylistWrite
    {
        public PlaylistWrite(WebSiteDbContext context) : base(context)
        {
        }
    }
}
