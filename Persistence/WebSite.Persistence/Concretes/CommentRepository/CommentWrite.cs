using WebSite.Application.ITablesRepositories.ICommentRepository;
using WebSite.Domain.Entities;
using WebSite.Persistence.Context;
using WebSite.Persistence.Repositories;

namespace WebSite.Persistence.Concretes.CommentRepository
{
    public class CommentWrite : WriteRepository<Comment>, ICommentWrite
    {
        public CommentWrite(WebSiteDbContext context) : base(context)
        {
        }
    }
}
