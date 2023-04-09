using System;
using SchoolProgramming.Entities.Abstract;

namespace SchoolProgramming.Entities.Concrete
{
	public class Student: IEntity
	{
		public int Id { get; set; }
		public int ClassroomId { get; set; }
		public string FullName { get; set; }
	}
}

