using WebSite.Application.ITablesRepositories.IUserRepository;
using WebSite.Domain.Entities;
using WebSite.Persistence.Context;
using WebSite.Persistence.Repositories;

namespace WebSite.Persistence.Concretes.UserRepository
{
    public class UserRead : ReadRepository<User>, IUserRead
    {
        public UserRead(WebSiteDbContext context) : base(context)
        {


        }
    }
}
