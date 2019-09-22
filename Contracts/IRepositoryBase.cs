using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IRepositoryBase<T>
    {
        IEnumerable<T> FindAll();
        IEnumerable<T> FindAllInheritance();
        IEnumerable<T> FindByConditionInheritance(Expression<Func<T, bool>> expression);
        IEnumerable<T> FindByCondition(Expression<Func<T, bool>> expression);
        IQueryable<T> FindByCondition2(Expression<Func<T, bool>> expression);
        IEnumerable<T> FromSql(string query, SqlParameter parameter);
        IEnumerable<T> FindConditionInclude(Expression<Func<T, bool>> expression, Func<IQueryable<T>, IIncludableQueryable<T, object>> includes = null);
        IEnumerable<T> FindAllInclude(Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null);
        Task<IEnumerable<T>> FindAllAsync();
        Task<IEnumerable<T>> FindByConditionAync(Expression<Func<T, bool>> expression);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        Task CreateAsync(T entity);
        void CreateRange(IEnumerable<T> entities);
        void UpdateRange(IEnumerable<T> entities);
        void DeleteRange(IEnumerable<T> entities);
        Task CreateRangeAsync(IEnumerable<T> entities);
        void Save();
        Task SaveAsync();
    }
}
