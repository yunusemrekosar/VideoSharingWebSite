using WebSite.Application.ITablesRepositories.ISubscriptionRepository;
using WebSite.Domain.Entities;
using WebSite.Persistence.Context;
using WebSite.Persistence.Repositories;

namespace WebSite.Persistence.Concretes.SubscriptionRepository
{
    public class SubscriptionRead : ReadRepository<Subscription>, ISubscriptionRead
    {
        public SubscriptionRead(WebSiteDbContext context) : base(context)
        {
        }
    }
}
