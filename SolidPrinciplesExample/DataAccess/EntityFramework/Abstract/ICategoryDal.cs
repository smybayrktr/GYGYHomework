using System;
using SolidPrinciplesExample.Entities.Concrete;

namespace SolidPrinciplesExample.DataAccess.EntityFramework.Abstract
{
	public interface ICategoryDal: IEntityRepository<Category>
	{
		/*
		 * Bu sınıf Category için veritabanı işlemlerinden sorumlu sınıftır.
		 * İlk olarak IEntityRepository interface i oluşturduk. Bu interface içerisine 
		 * her entity in veritabanından sorumlu sınıfı için lazım olan 
		 * Ekleme-Silme-Güncelleme-Listeleme operasyoları yazılmıştır. Bu yapı generic olarak 
		 * oluşturulmuştur ve her veritabanı nesnesi kendisi için oluşturmaktadır.
		 * ICategoryDal da tüm bu ortak metotları kendi içinde barındırırken kendine has 
		 * metotları da içerisinde barındıracaktır.
		*/

		void CategoryFilter(); //Örneğin kategoriye özel bir metot oldu.

	}
}

