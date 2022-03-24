using FindHome_BLL.Contracts;
using FindHome_DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FindHome_BLL.Implementations
{
    public class Repository<T> : IRepositoryBase<T> where T : class, new()
    {
        
        protected readonly Context _Context;
        public Repository(Context Context)
        {
            _Context = Context;
        }

        public bool Add(T entity)
        {
            try
            {
                bool result = false;
                _Context.Set<T>().Add(entity);
                result = _Context.SaveChanges() > 0 ? true : false;
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool Delete(T entity)
        {
            try
            {
                bool result = false;
                _Context.Set<T>().Remove(entity);
                result = _Context.SaveChanges() > 0 ? true : false;
                return result;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public T GetById(int id)
        {
            try
            {
                return _Context.Set<T>().Find(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IQueryable<T> GetAll(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = null)
        {
            try
            {
                IQueryable<T> query = _Context.Set<T>();

               
                if (filter != null)
                {
                    query = query.Where(filter);
                }
                
                if (includeProperties != null)
                {
                    foreach (var item in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                    {
                        query = query.Include(item);
                    }
                }

                if (orderBy != null)
                {
                    return orderBy(query);
                }
                return query;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public T GetFirstOrDefault(Expression<Func<T, bool>> filter = null, string includeProperties = null)
        {
            try
            {
                IQueryable<T> query = _Context.Set<T>();

                
                if (filter != null)
                {
                    query = query.Where(filter);
                }
                
                if (includeProperties != null)
                {
                    foreach (var item in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                    {
                        query = query.Include(item);
                    }
                }
                return query.FirstOrDefault();
            }



            catch (Exception)
            {

                throw;
            }

        }

        public bool Update(T entity)
        {
            try
            {
                bool result = false;
                _Context.Set<T>().Update(entity);
                result = _Context.SaveChanges() > 0 ? true : false;
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
