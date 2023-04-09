using System;
using System.Linq.Expressions;
using SchoolProgramming.Entities.Abstract;
using SchoolProgramming.Entities.Concrete;

namespace SchoolProgramming.Core.DataAccess.InMemory
{
    public class InMemoryRepositoryBase<T> : IRepository<T> where T: IEntity,new()
    {
        private readonly List<T> entityList = new List<T>();
        private static int _idCounter = 1;

        public void Add(T entity)
        {
            entity.Id = _idCounter;
            _idCounter++;
            entityList.Add(entity);
        }

        public void Delete(T entity)
        {
            entityList.Remove(entity);
        }

        public List<T> GetAll()
        {
            return entityList;
        }

        public List<T> GetByList(Expression<Func<T, bool>> predicate)
        {
            return entityList.Where(predicate.Compile()).ToList();
        }

        public T? FindBy(Expression<Func<T, bool>> predicate)
        {
            return entityList.SingleOrDefault(predicate.Compile());
        }
    }
}

