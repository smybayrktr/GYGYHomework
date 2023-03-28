using System;
using SolidPrinciplesExample.Entities.Concrete;

namespace SolidPrinciplesExample.DataAccess.EntityFramework.Abstract
{
    /*
		 * Bu sınıf Recipe için veritabanı işlemlerinden sorumlu sınıftır.
		 * İlk olarak IEntityRepository interface i oluşturduk. Bu interface içerisine 
		 * her entity in veritabanından sorumlu sınıfı için lazım olan 
		 * Ekleme-Silme-Güncelleme-Listeleme operasyoları yazılmıştır. Bu yapı generic olarak 
		 * oluşturulmuştur ve her veritabanı nesnesi kendisi için oluşturmaktadır.
		 * IRecipeDal da tüm bu ortak metotları kendi içinde barındırırken kendine has 
		 * metotları da içerisinde barındıracaktır.
		*/

    public interface IRecipeDal:IEntityRepository<Recipe>
	{

	}
}

