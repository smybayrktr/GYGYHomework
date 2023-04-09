using System;
using System.Linq.Expressions;
using SchoolProgramming.Entities.Abstract;
using SchoolProgramming.Entities.Concrete;

namespace SchoolProgramming.Core.DataAccess
{
	public interface IRepository<T> where T: IEntity,new()
	{
        void Add(T entity);
        void Delete(T entity);
        List<T> GetAll();
        List<T> GetByList(Expression<Func<T, bool>> predicate);
        T? FindBy(Expression<Func<T, bool>> predicate);
    }
}

