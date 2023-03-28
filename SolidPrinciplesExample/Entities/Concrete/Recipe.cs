using System;
using SolidPrinciplesExample.Entities.Abstract;

namespace SolidPrinciplesExample.Entities.Concrete
{
    //Veritabanındaki tabloların sınıf karşılıklarıdır.

    public class Recipe: IEntity
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int CategoryId { get; set; }
		public string Description { get; set; }
		public DateTime DateTime { get; set; }
	}
}

