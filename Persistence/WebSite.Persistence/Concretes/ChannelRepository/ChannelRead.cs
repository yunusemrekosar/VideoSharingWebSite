using WebSite.Application.ITablesRepositories.IChannelRepository;
using WebSite.Domain.Entities;
using WebSite.Persistence.Context;
using WebSite.Persistence.Repositories;

namespace WebSite.Persistence.Concretes.NewFolder1
{
    public class ChannelRead : ReadRepository<Channel>, IChannelRead
    {
        public ChannelRead(WebSiteDbContext context) : base(context)
        {
        }
    }
}
