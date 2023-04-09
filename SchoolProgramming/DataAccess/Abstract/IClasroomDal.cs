using System;
using System.Linq.Expressions;
using SchoolProgramming.Core.DataAccess;
using SchoolProgramming.Entities.Abstract;
using SchoolProgramming.Entities.Concrete;

namespace SchoolProgramming.DataAccess.Abstract
{
	public interface IClassroomDal:IRepository<Classroom>
	{
       
    }
}

