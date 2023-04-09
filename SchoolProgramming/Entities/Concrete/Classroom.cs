using System;
using SchoolProgramming.Entities.Abstract;

namespace SchoolProgramming.Entities.Concrete
{
	public class Classroom : IEntity
	{
        public int Id { get; set; }
        public string ClassroomName { get; set; }       
	}
}

