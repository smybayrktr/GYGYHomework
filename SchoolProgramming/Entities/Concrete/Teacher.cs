using System;
using SchoolProgramming.Entities.Abstract;

namespace SchoolProgramming.Entities.Concrete
{
	public class Teacher: IEntity
	{
		public int Id { get; set; }
		public int ClassroomId { get; set; } = 0;
		public string FullName { get; set; }
	}
}

