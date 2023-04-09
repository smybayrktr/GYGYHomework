using System;
using SchoolAutomation.Entities.Concrete;

namespace SchoolAutomation.DataAccess.Abstract
{
	public interface IStudentDal
	{
        void AddStudent(Student student);
        void RemoveStudent(Student student);
        List<Student> GetAll();
    }
}

