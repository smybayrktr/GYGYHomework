using System;
using SchoolAutomation.Entities.Abstract;

namespace SchoolAutomation.Entities.Concrete
{
	public class Teacher: IEntity
	{
		public int Id { get; set; }
		public string FullName { get; set; }

		public Teacher(string fullName)
		{
			FullName = fullName;
		}
	}
}

