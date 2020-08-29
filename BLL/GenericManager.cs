using LoginProject1.Interfaces;
using LoginProjectDal.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace LoginProject1.BLL
{

    //Communicating with DAL via IGenericRepository
    public class GenericManager<T> : IGenericService<T> where T: class
    {

        //Database independence, more flexibility
        private readonly IGenericRepository<T> genericRepository;


        //Constructor
        public GenericManager(IGenericRepository<T> genericRepository)
        {
            this.genericRepository = genericRepository;
        }

        public T Add(T entity)
        {
            return genericRepository.Add(entity);
        }

        public void Dispose()
        {
            //GC.SuppressFinalize()
            Dispose(true);
            GC.SuppressFinalize(this); // Garbage Collector
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                genericRepository.Dispose();
            }
        }

        public T Get(int id)
        {

            return genericRepository.Get(id);

        }

        public List<T> GetAll()
        {

            return genericRepository.GetAll();

        }

        public List<T> GetAll(Expression<Func<T, bool>> predicate)
        {
            return genericRepository.GetAll(predicate);
        }

        public bool Remove(int id)
        {
            return genericRepository.Remove(id);
        }

        public bool Remove(T entity)
        {

            return genericRepository.Remove(entity);
        }

        public T Update(T entity)
        {

            return genericRepository.Update(entity);
        }
    }
}
