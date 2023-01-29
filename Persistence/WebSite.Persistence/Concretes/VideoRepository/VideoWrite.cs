using WebSite.Application.ITablesRepositories.IVideoRepository;
using WebSite.Domain.Entities;
using WebSite.Persistence.Context;
using WebSite.Persistence.Repositories;

namespace WebSite.Persistence.Concretes.VideoRepository
{
    public class VideoWrite : WriteRepository<Video>, IVideoWrite
    {
        public VideoWrite(WebSiteDbContext context) : base(context)
        {
        }
    }
}
