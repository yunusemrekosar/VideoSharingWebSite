using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WebSite.Application.Repositories;
using WebSite.Domain.Entities.Common;
using WebSite.Persistence.Context;

namespace WebSite.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {

        private readonly WebSiteDbContext _context;

        public ReadRepository(WebSiteDbContext context)
        {
            _context = context; 
        }

        public DbSet<T> Table => _context.Set<T>(); 

        public IQueryable<T> GetAll(bool tracking = true)
        {
            var query =  Table.AsQueryable();
            if(!tracking) query= query.AsNoTracking();
            return query;
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> expression, bool tracking = true)
        {
            var query = Table.AsQueryable();
            if (!tracking) query = query.AsNoTracking();
            return query.Where(expression);
        }
         
        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> expression, bool tracking = true)
        {
            var query = Table.AsQueryable();
            if (!tracking) query = query.AsNoTracking();
            return await query.FirstOrDefaultAsync(expression);
        } 

        public async Task<T> GetByIdAsync(int id, bool tracking = true)
        {
            var query = Table.AsQueryable();
            if (!tracking) query = query.AsNoTracking();
            return await query.FirstOrDefaultAsync(d=>d.Id==id);
        }

    }

}
