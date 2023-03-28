using System;
using SolidPrinciplesExample.DataAccess.EntityFramework.Abstract;
using SolidPrinciplesExample.Entities.Concrete;

namespace SolidPrinciplesExample.DataAccess.EntityFramework.Concrete
{
    /*
     * IEntityRepository interface inin içerisindeki metotlar EfEntityRepository sınıfında doldurulmuştur.
     * Bu doldurma işlemi generic olarak yapılir. Generic olarak yapıldığı için sınıfa sadece
     * Hangi context için ve hangi veritabanı nesnesi için doldurulacağı bilgisi verilir.
     * IRecipeDal interfacesi içine sadece Recipeyi ilgilendiren metotları yazdığımız 
     * içinde onu ayrıca implement edip içerisini dolduracağımız yer.
     */
    public class EfRecipeDal:EfEntityRepository<Recipe,RecipeWebContext>,IRecipeDal
	{
		
	}
}

