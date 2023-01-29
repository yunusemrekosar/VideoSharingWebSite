using WebSite.Application.ITablesRepositories.IUserDislikeRepository;
using WebSite.Domain.Entities;
using WebSite.Persistence.Context;
using WebSite.Persistence.Repositories;

namespace WebSite.Persistence.Concretes.UserDislikedRepository
{
    public class UserDislikedWrite : WriteRepository<UserDislikedVideo>, IUserDislikedVideoWrite
    {
        public UserDislikedWrite(WebSiteDbContext context) : base(context)
        {
        }
    }
}
