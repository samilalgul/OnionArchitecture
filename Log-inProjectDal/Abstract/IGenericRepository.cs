using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace LoginProjectDal.Abstract
{
    public interface IGenericRepository<T>:IDisposable where T: class
    {
        T Add(T entity);

        T Get(int id);

        List<T> GetAll();

        List<T> GetAll(Expression<Func<T, bool>> predicate);

        bool Remove(int id);
        bool Remove(T entity);

        T Update(T entity);

    }
}
