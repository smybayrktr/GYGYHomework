using System;
using SchoolProgramming.Business.Abstract;
using SchoolProgramming.DataAccess.Abstract;
using SchoolProgramming.Entities.Concrete;

namespace SchoolProgramming.Business.Concrete
{
    public class TeacherManager : ITeacherService
    {
        private readonly ITearcherDal _teacherDal;

        public TeacherManager(ITearcherDal teacherDal)
        {
            _teacherDal = teacherDal;
        }

        public void Add(Teacher teacher)
        {
            if (String.IsNullOrEmpty(teacher.FullName))
            {
                Console.WriteLine("Öğretmen ismi boş olamaz!");
                return;
            }
            _teacherDal.Add(teacher);
        }

        public void Delete(Teacher teacher)
        {
            _teacherDal.Delete(teacher);
        }

        public List<Teacher> GetAll()
        {
            return _teacherDal.GetAll();
        }

        public Teacher? GetById(int id)
        {
            return _teacherDal.FindBy(x => x.Id == id);
        }
        public void AddTeacherToClassroom(int classroomId, Teacher teacher)
        {
            if (teacher.ClassroomId != 0)
            {
                Console.WriteLine("Öğretmen zaten bir sınıfa kayıtlı!");
                return;
            }

            var checkIfClassroomHasTeacher = _teacherDal.FindBy(x => x.ClassroomId == classroomId);    
            if (checkIfClassroomHasTeacher!=null)
            {
                Console.WriteLine("Bu sınıfa zaten bir öğretmen kayıtlı!");
                return;
            }

            teacher.ClassroomId = classroomId;
            _teacherDal.Add(teacher);
        }
        public Teacher? GetTeacherInClassroom(int classroomId)
        {
            return _teacherDal.FindBy(x => x.ClassroomId == classroomId);
        }
        public void WriteToConsole(List<Teacher> teachers)
        {
            foreach (var teacher in teachers)
            {
                Console.WriteLine($"Öğretmen ID: {teacher.Id} Öğretmen Adı: {teacher.FullName}");
            }
        }
        public void WriteToConsole(Teacher teacher)
        {
            Console.WriteLine($"Öğretmen ID: {teacher.Id} Öğretmen Adı: {teacher.FullName}");
        }
    }
}

