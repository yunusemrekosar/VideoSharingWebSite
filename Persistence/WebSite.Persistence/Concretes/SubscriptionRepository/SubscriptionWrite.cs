using WebSite.Application.ITablesRepositories.ISubscriptionRepository;
using WebSite.Domain.Entities;
using WebSite.Persistence.Context;
using WebSite.Persistence.Repositories;

namespace WebSite.Persistence.Concretes.SubscriptionRepository
{
    public class SubscriptionWrite : WriteRepository<Subscription>, ISubscriptionWrite
    {
        public SubscriptionWrite(WebSiteDbContext context) : base(context)
        {
        }
    }
}
