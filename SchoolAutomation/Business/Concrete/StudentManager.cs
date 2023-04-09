using System;
using SchoolAutomation.Business.Abstract;
using SchoolAutomation.DataAccess.Abstract;
using SchoolAutomation.DataAccess.Concrete;
using SchoolAutomation.Entities.Concrete;

namespace SchoolAutomation.Business.Concrete
{
    public class StudentManager : IStudentService
    {
        InMemoryStudentDal _studentDal;

        public StudentManager(InMemoryStudentDal studentDal)
        {
            _studentDal = studentDal;
        }

        public void AddStudent(Student student)
        {
            _studentDal.AddStudent(student);
        }

        public List<Entities.Concrete.Student> GetAll()
        {
            return _studentDal.GetAll();
        }
    }
}

