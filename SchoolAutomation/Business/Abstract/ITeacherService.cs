using System;
using SchoolAutomation.Entities.Concrete;

namespace SchoolAutomation.Business.Abstract
{
	public interface ITeacherService
	{
        void AddTeacher(Teacher teacher);
        List<Teacher> GetAll();
    }
}

