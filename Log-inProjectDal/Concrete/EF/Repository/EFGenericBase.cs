using LoginProjectDal.Abstract;
using LoginProjectDal.Concrete.EF.Context;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

using System.Text;

namespace LoginProjectDal.Concrete.EF.Repository
{
    public class EFGenericBase<T> : IGenericRepository<T> where T: class
    {

        public RestaurantDBContext dBContext;

        public T Add(T entity)
        {
            dBContext.Set<T>().Add(entity);
            return entity; // also select from db
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool dispose)
        {
            if (dispose)
            {
                dBContext.Dispose();
            }
        }

        public T Get(int id)
        {
            var entity = dBContext.Set<T>().Find(id);
            return entity;
        }

        public List<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            return Remove(Get(id));
        }

        public bool Remove(T entity)
        {
            dBContext.Set<T>().Remove(entity);
            return dBContext.SaveChanges() > 0;

        }

        public T Update(T entity)
        {
            dBContext.Set<T>().Update(entity);
            dBContext.SaveChanges();
            return entity;
        }
    }
}
