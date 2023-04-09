using System;
using SchoolAutomation.Entities.Abstract;

namespace SchoolAutomation.Entities.Concrete
{
	public class Classroom : IEntity
	{
        public int Id { get; set; }
        public string ClassroomName { get; set; }
        public int Capacity { get; set; }
        public Teacher Teacher { get; set; }
        public List<Student> Students { get; set; }

        public Classroom(string classroomName, int capacity, List<Student> students)
		{
            ClassroomName = classroomName;
            Capacity = capacity;
            Students = students;
        }
	}
}

