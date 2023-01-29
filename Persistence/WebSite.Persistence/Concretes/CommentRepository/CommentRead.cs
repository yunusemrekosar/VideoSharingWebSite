using WebSite.Application.ITablesRepositories.ICommentRepository;
using WebSite.Domain.Entities;
using WebSite.Persistence.Context;
using WebSite.Persistence.Repositories;

namespace WebSite.Persistence.Concretes.CommentRepository
{
    public class CommentRead : ReadRepository<Comment>, ICommentRead
    {
        public CommentRead(WebSiteDbContext context) : base(context)
        {
        }
    }
}
