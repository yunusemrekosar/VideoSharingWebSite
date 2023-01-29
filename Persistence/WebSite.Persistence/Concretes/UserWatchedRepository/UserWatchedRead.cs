using WebSite.Application.ITablesRepositories.IUserWatchedRepository;
using WebSite.Domain.Entities;
using WebSite.Persistence.Context;
using WebSite.Persistence.Repositories;

namespace WebSite.Persistence.Concretes.UserWatchedRepository
{
    public class UserWatchedRead : ReadRepository<UserWatchedVideo>, IUserWatchedRead
    {
        public UserWatchedRead(WebSiteDbContext context) : base(context)
        {
        }
    }
}
