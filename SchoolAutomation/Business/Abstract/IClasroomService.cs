using System;
using SchoolAutomation.Entities.Concrete;

namespace SchoolAutomation.Business.Abstract
{
	public interface IClasroomService
	{
        void AddClassroom(Classroom classroom);
        List<Classroom> GetAll();
    }
}

