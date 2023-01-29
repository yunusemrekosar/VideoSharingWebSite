using WebSite.Application.ITablesRepositories.IUserDislikeRepository;
using WebSite.Domain.Entities;
using WebSite.Persistence.Context;
using WebSite.Persistence.Repositories;

namespace WebSite.Persistence.Concretes.UserDislikedRepository
{
    public class UserDislikedRead : ReadRepository<UserDislikedVideo>, IUserDislikedVideoRead
    {
        public UserDislikedRead(WebSiteDbContext context) : base(context)
        {
        }
    }
}
