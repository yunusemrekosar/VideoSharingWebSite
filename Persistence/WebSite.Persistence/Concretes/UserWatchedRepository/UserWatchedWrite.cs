using WebSite.Application.ITablesRepositories.IUserWatchedRepository;
using WebSite.Domain.Entities;
using WebSite.Persistence.Context;
using WebSite.Persistence.Repositories;

namespace WebSite.Persistence.Concretes.UserWatchedRepository
{
    public class UserWatchedWrite : WriteRepository<UserWatchedVideo>, IUserWatchedWrite
    {
        public UserWatchedWrite(WebSiteDbContext context) : base(context)
        {
        }
    }
}
