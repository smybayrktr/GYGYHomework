using System;
using SchoolAutomation.Entities.Concrete;

namespace SchoolAutomation.Business.Abstract
{
	public interface IStudentService
	{
        void AddStudent(Entities.Concrete.Student student);
        List<Entities.Concrete.Student> GetAll();
    }
}

