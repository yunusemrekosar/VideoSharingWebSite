using WebSite.Application.ITablesRepositories.IUserLikedVideoRepository;
using WebSite.Domain.Entities;
using WebSite.Persistence.Context;
using WebSite.Persistence.Repositories;

namespace WebSite.Persistence.Concretes.UserLikedRepository
{
    public class UserLikedWrite : WriteRepository<UserLikedVideo>, IUserLikedVideoWrite
    {
        public UserLikedWrite(WebSiteDbContext context) : base(context)
        {
        }
    }
}
