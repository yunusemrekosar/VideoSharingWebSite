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

        public IQueryable<T> GetAll()
        {
            return Table;
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> expression)
        {
            return Table.Where(expression);
        }
         
        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> expression)
        {
            return await Table.FirstOrDefaultAsync(expression);
        } 

        public async Task<T> GetByIdAsync(int id)
        {
            return await Table.FindAsync(id);
        }  
    }

}
