using System;
using SchoolProgramming.Entities.Concrete;

namespace SchoolProgramming.Business.Abstract
{
	public interface ITeacherService
	{
        List<Teacher> GetAll();
        void Add(Teacher teacher);
        void Delete(Teacher teacher);
        Teacher? GetById(int id);
        void AddTeacherToClassroom(int classroomId, Teacher teacher);
        Teacher? GetTeacherInClassroom(int classroomId);
        void WriteToConsole(Teacher teacher);
        void WriteToConsole(List<Teacher> teacher);
    }
}

