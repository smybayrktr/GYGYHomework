using System;
using SchoolProgramming.Entities.Concrete;

namespace SchoolProgramming.Business.Abstract
{
	public interface IStudentService
	{
        List<Student> GetAll();
        void Add(Student student);
        void Delete(Student student);
        Student? GetById(int id);
        void AddStudentToClassroom(int classroomId, Student student);
        List<Student> GetStudentsInClassroom(int classroomId);
        void WriteToConsole(List<Student> students);
    }
}

