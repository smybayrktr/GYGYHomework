using System;
using SchoolProgramming.Business.Abstract;
using SchoolProgramming.DataAccess.Abstract;
using SchoolProgramming.Entities.Concrete;

namespace SchoolProgramming.Business.Concrete
{
    public class ClassroomManager : IClassroomService
    {
        private readonly IClassroomDal _classroomDal;

        public ClassroomManager(IClassroomDal classroomDal)
        {
            _classroomDal = classroomDal;
        }

        public void Add(Classroom classroom)
        {
            var checkIfClassroomNameExists = _classroomDal.FindBy(x => x.ClassroomName.ToLower() == classroom.ClassroomName.ToLower());
            if (checkIfClassroomNameExists!=null)
            {
                Console.WriteLine("Bu isimde bir sınıf zaten kayıtlı!");
                return;     
            }
            if (String.IsNullOrEmpty(classroom.ClassroomName))
            {
                Console.WriteLine("Sınıf ismi boş olamaz!");
                return;
            }
            _classroomDal.Add(classroom);
        }

        public void Delete(Classroom classroom)
        {
            _classroomDal.Delete(classroom);
        }

        public List<Classroom> GetAll()
        {
            return _classroomDal.GetAll();
        }

        public Classroom? GetById(int id)
        {
            return _classroomDal.FindBy(x => x.Id == id);
        }

        public void WriteToConsole(List<Classroom> classrooms)
        {
            foreach (var classroom in classrooms)
            {
                Console.WriteLine($"Sınıf ID: {classroom.Id} Sınıf Adı: {classroom.ClassroomName}");
            }
        }
    }
}

