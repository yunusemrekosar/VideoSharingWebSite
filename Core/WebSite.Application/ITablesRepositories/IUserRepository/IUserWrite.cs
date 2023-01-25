using WebSite.Application.Repositories;
using WebSite.Domain.Entities;

namespace WebSite.Application.ITablesRepositories.IUserRepository
{
    public interface IUserWrite : IWriteRepository<User>
    {
    }
}
