using System;
using SchoolAutomation.DataAccess.Abstract;

namespace SchoolAutomation.DataAccess.Concrete
{
	public class InMemoryStudentDal: IStudentDal
	{
        public List<Student> _students;

        public InMemoryStudentDal()
        {
            _students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            _students.Add(student);
        }

        public void RemoveStudent(Student ogrenci)
        {
            _students.Remove(ogrenci);
        }

        public List<Student> GetAll()
        {
            return _students;
        }
    }
}

