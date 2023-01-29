using WebSite.Application.ITablesRepositories.ISubcommentRepository;
using WebSite.Domain.Entities;
using WebSite.Persistence.Context;
using WebSite.Persistence.Repositories;

namespace WebSite.Persistence.Concretes.SubcommentRepository
{
    public class SubcommentRead : ReadRepository<SubComment>, ISubcommentRead
    {
        public SubcommentRead(WebSiteDbContext context) : base(context)
        {
        }
    }
}
