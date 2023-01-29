using WebSite.Application.ITablesRepositories.ISubcommentRepository;
using WebSite.Domain.Entities;
using WebSite.Persistence.Context;
using WebSite.Persistence.Repositories;

namespace WebSite.Persistence.Concretes.SubcommentRepository
{
    public class SubcommentWrite : WriteRepository<SubComment>, ISubcommentWrite
    {
        public SubcommentWrite(WebSiteDbContext context) : base(context)
        {
        }
    }
}
