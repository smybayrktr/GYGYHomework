using System;
using SchoolProgramming.Business.Abstract;
using SchoolProgramming.DataAccess.Abstract;
using SchoolProgramming.Entities.Concrete;

namespace SchoolProgramming.Business.Concrete
{
    public class StudentManager : IStudentService
    {
        private readonly IStudentDal _studentDal;

        public StudentManager(IStudentDal studentDal)
        {
            _studentDal = studentDal;
        }

        public void Add(Student student)
        {
            if (String.IsNullOrEmpty(student.FullName))
            {
                Console.WriteLine("Öğrenci ismi boş olamaz!");
                return;
            }
            _studentDal.Add(student);
        }

        public void Delete(Student student)
        {
            _studentDal.Delete(student);
        }

        public List<Student> GetAll()
        {
            return _studentDal.GetAll();
        }

        public Student? GetById(int id)
        {
            return _studentDal.FindBy(x => x.Id == id);
        }

        public void AddStudentToClassroom(int classroomId, Student student)
        {
            if (student.ClassroomId != 0)
            {
                Console.WriteLine("Öğrenci zaten bir sınıfa kayıtlı!");
                return;
            }

            student.ClassroomId = classroomId;
            _studentDal.Add(student);
        }
        public List<Student> GetStudentsInClassroom(int classroomId)
        {
            return _studentDal.GetByList(x => x.ClassroomId == classroomId);
        }
        public void WriteToConsole(List<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine($"Öğrenci ID: {student.Id} Öğrenci Adı: {student.FullName}");
            }
        }
    }
}

