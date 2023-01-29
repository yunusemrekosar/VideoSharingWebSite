using WebSite.Application.ITablesRepositories.IUserRepository;
using WebSite.Domain.Entities;
using WebSite.Persistence.Context;
using WebSite.Persistence.Repositories;

namespace WebSite.Persistence.Concretes.UserRepository
{
    public class UserWrite : WriteRepository<User>, IUserWrite
    {
        public UserWrite(WebSiteDbContext context) : base(context)
        {
        }
    }
}
