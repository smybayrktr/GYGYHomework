using System;
using SchoolProgramming.Entities.Concrete;

namespace SchoolProgramming.Business.Abstract
{
	public interface IClassroomService
	{
        List<Classroom> GetAll();
        void Add(Classroom classroom);
        void Delete(Classroom classroom);
        Classroom? GetById(int id);
        void WriteToConsole(List<Classroom> classrooms);
    }
}

