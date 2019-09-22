using Contracts;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Repository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected DbExpertAutoContext RepositoryContext { get; set; }

        public RepositoryBase(DbExpertAutoContext repositoryContext)
        {
            this.RepositoryContext = repositoryContext;
        }

        public IEnumerable<T> FindAll()
        {
            return this.RepositoryContext.Set<T>();
        }

        public IEnumerable<T> FindAllInheritance()
        {
            return this.RepositoryContext.Set<T>().OfType<T>();
        }

        public IEnumerable<T> FindByConditionInheritance(Expression<Func<T, bool>> expression)
        {
            return this.RepositoryContext.Set<T>().OfType<T>().Where(expression);
        }

        public IEnumerable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return this.RepositoryContext.Set<T>().Where(expression);
        }

        public IQueryable<T> FindByCondition2(Expression<Func<T, bool>> expression)
        {
            return this.RepositoryContext.Set<T>().Where(expression);
        }


        public IEnumerable<T> FindAllInclude(Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null) 
        {
            var result = this.RepositoryContext.Set<T>().AsQueryable();

            if (include != null)
                result = include(result);

            return result;
        }

        public IEnumerable<T> FindConditionInclude(Expression<Func<T, bool>> expression, Func<IQueryable<T>, IIncludableQueryable<T, object>> includes = null) 
        {

            IQueryable<T> queryable = this.RepositoryContext.Set<T>().Where(expression); 

            if (includes != null)
            {
                queryable = includes(queryable);
            }
            return queryable ;
        }

        public IEnumerable<T> FromSql(string query,SqlParameter parameter)
        {
            return this.RepositoryContext.Set<T>().FromSql(query, parameter);
        }


        public async Task<IEnumerable<T>> FindAllAsync()
        {
            return await this.RepositoryContext.Set<T>().ToListAsync();
        }

        public async Task<IEnumerable<T>> FindByConditionAync(Expression<Func<T, bool>> expression)
        {
            return await this.RepositoryContext.Set<T>().Where(expression).ToListAsync();
        }

        public void Create(T entity)
        {
            this.RepositoryContext.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            this.RepositoryContext.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            this.RepositoryContext.Set<T>().Remove(entity);
        }

        public void Save()
        {
            this.RepositoryContext.SaveChanges();
        }

        public async Task SaveAsync()
        {
            await this.RepositoryContext.SaveChangesAsync();
        }

        public async Task CreateAsync(T entity)
        {
            await this.RepositoryContext.Set<T>().AddAsync(entity);
        }

        public void CreateRange(IEnumerable<T> entities)
        {
            this.RepositoryContext.Set<T>().AddRange(entities);
        }

        public void UpdateRange(IEnumerable<T> entities)
        {
            this.RepositoryContext.Set<T>().UpdateRange(entities);
        }

        public void DeleteRange(IEnumerable<T> entities)
        {
            this.RepositoryContext.Set<T>().RemoveRange(entities);
        }

        public async Task CreateRangeAsync(IEnumerable<T> entities)
        {
            await this.RepositoryContext.Set<T>().AddRangeAsync(entities);
        }

        //public IEnumerable<T> GetPaged<T>(this IQueryable<T> query,int page, int pageSize) 
                                         
        //{

        //    this.RepositoryContext.S
        //    var result = new PagedResult<T>();

        //    result.CurrentPage = page;
        //    result.PageSize = pageSize;
        //    result.RowCount = query.Count();


        //    var pageCount = (double)result.RowCount / pageSize;

        //    result.PageCount = (int)Math.Ceiling(pageCount);

        //    var skip = (page - 1) * pageSize;

        //    result.Results = query.Skip(skip).Take(pageSize).ToList();



        //    return result;
        //}
    }
}
