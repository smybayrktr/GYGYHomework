using System;
using SolidPrinciplesExample.Entities.Abstract;

namespace SolidPrinciplesExample.Entities.Concrete
{
	//Veritabanındaki tabloların sınıf karşılıklarıdır.

	public class Category: IEntity
	{
		public int Id { get; set; }
		public string Name { get; set; }

	}
}

