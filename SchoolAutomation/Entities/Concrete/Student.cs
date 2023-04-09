using System;
using SchoolAutomation.Entities.Abstract;

namespace SchoolAutomation.Entities.Concrete
{
	public class Student: IEntity
	{
		public int Id { get; set; }
		public string FullName { get; set; }
		public Classroom ClassroomName { get; set; }

		public Student()
		{
		}
	}
}

