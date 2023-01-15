﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WebSite.Domain.Entities.Common;

namespace WebSite.Application.Repositories
{
    public interface IReadRepository<T>: IRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll();

        IQueryable<T> GetWhere(Expression<Func<T, bool>> expression);

        Task<T> GetSingleAsync(Expression<Func<T, bool>> expression);

        Task<T> GetByIdAsync(int id);


    }

}
