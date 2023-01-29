using WebSite.Application.ITablesRepositories.IVideoRepository;
using WebSite.Domain.Entities;
using WebSite.Persistence.Context;
using WebSite.Persistence.Repositories;

namespace WebSite.Persistence.Concretes.VideoRepository
{
    public class VideoRead : ReadRepository<Video>, IVideoRead
    {
        public VideoRead(WebSiteDbContext context) : base(context)
        {
        }
    }
}
