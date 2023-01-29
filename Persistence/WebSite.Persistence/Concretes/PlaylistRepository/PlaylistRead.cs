using WebSite.Application.ITablesRepositories.IPlaylistRepository;
using WebSite.Domain.Entities;
using WebSite.Persistence.Context;
using WebSite.Persistence.Repositories;

namespace WebSite.Persistence.Concretes.PlaylistRepository
{
    public class PlaylistRead : ReadRepository<Playlist>, IPlaylistRead
    {
        public PlaylistRead(WebSiteDbContext context) : base(context)
        {
        }
    }
}
