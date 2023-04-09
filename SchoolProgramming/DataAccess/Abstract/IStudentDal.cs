using System;
using System.Linq.Expressions;
using SchoolProgramming.Core.DataAccess;
using SchoolProgramming.Entities.Concrete;

namespace SchoolProgramming.DataAccess.Abstract
{
	public interface IStudentDal:IRepository<Student>
	{
       
    }
}

