using WebSite.Application.ITablesRepositories.IUserLikedVideoRepository;
using WebSite.Domain.Entities;
using WebSite.Persistence.Context;
using WebSite.Persistence.Repositories;

namespace WebSite.Persistence.Concretes.UserLikedRepository
{
    internal class UserLikedRead : ReadRepository<UserLikedVideo>, IUserLikedVideoRead
    {
        public UserLikedRead(WebSiteDbContext context) : base(context)
        {
        }
    }
}
