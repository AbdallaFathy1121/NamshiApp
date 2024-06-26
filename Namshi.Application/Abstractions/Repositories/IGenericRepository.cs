﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Namshi.Application.Abstractions.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IReadOnlyList<T>> GetAllAsync();
        Task<IEnumerable<T>> GetAllAsync(params Expression<Func<T, object>>[] includes);
        Task<T> GetAsync(T id);
        Task AddAsync(T entity);
        Task UpdateAsync(T id, T entity);
        Task DeleteAsync(T id);
    }
}
