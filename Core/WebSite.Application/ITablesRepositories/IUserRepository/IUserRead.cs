using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSite.Application.Repositories;
using WebSite.Domain.Entities;

namespace WebSite.Application.ITablesRepositories.IUserRepository
{
    public interface IUserRead : IReadRepository<User>
    {
    }
}
