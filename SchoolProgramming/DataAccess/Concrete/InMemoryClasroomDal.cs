

using System.Linq.Expressions;
using SchoolProgramming.Core.DataAccess.InMemory;
using SchoolProgramming.DataAccess.Abstract;
using SchoolProgramming.Entities.Concrete;

namespace SchoolProgramming.DataAccess.Concrete
{
    public class InMemoryClassroomDal: InMemoryRepositoryBase<Classroom>,IClassroomDal
    {
      
    }
}

