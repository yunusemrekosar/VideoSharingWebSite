using WebSite.Application.ITablesRepositories.IChannelRepository;
using WebSite.Persistence.Context;
using WebSite.Persistence.Repositories;
using WebSite.Domain.Entities;

namespace WebSite.Persistence.Concretes.NewFolder1
{

    public class ChannelWrite : WriteRepository<Channel>, IChannelWrite
    {
        public ChannelWrite(WebSiteDbContext context) : base(context)
        {
        }
    }
}
