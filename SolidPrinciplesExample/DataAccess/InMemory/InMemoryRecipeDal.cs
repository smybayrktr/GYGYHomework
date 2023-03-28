using System;
using System.Linq.Expressions;
using SolidPrinciplesExample.DataAccess.EntityFramework.Abstract;
using SolidPrinciplesExample.Entities.Concrete;

namespace SolidPrinciplesExample.DataAccess.InMemory
{
    /*
     * Sistemimiz bellek(liste) üzerine kaydederken entity frameworke geçirmeye karar verdik.
     * Bu senaryoda InMemoryRecipeDal'da EfRecipeDal'da aslında IRecipeDal nesnesi olduğu
     * için herhangi bir sorun yaşamadan geçirdik. Örneği program.cs de.
     * Bu senaryo Open Closed Principle yapısına da uygun bir örnektir.
     * Interface kullanarak HİÇBİR ŞEY DEĞİŞTİRMEDEN YENİ ÖZELLİK EKLEDİK.
     */

    //Listeler üzerinde ekleme-silme-güncelleme ve listeleme yapan sınıf.

    public class InMemoryRecipeDal: IRecipeDal
	{
        
            List<Recipe> _repices;

            public InMemoryRecipeDal()
            {
                _repices = new List<Recipe>
            {
                new Recipe{ Id=1, CategoryId=1, Name="Adana Kebap",  Description="Adana kebap böyle yapılır",                    DateTime=DateTime.Now},
                new Recipe{ Id=2, CategoryId=1, Name ="Urfa Kebap", Description="Urfa da böyle yapılır", DateTime=DateTime.Now},
                new Recipe{ Id=3, CategoryId=2, Name="Güllaç", Description="Güllaç Tarifi",
                    DateTime=DateTime.Now},
                new Recipe{ Id=4, CategoryId=2, Name="Baklava", Description="Baklava Tarifi",
                    DateTime=DateTime.Now},
                new Recipe{ Id=5, CategoryId=3, Name="Domates Çorbası", Description="Domatesler soyulur.", DateTime=DateTime.Now },
                new Recipe{ Id=6, CategoryId=4, Name="Patates Kızartması", Description="Yağa patates atılır", DateTime=DateTime.Now }
            };
            }

            public void Add(Recipe recipe)
            {
                _repices.Add(recipe);
            }

            public void Delete(Recipe recipe)
            {
                Recipe recipeToDelete = _repices.SingleOrDefault(p => p.Id == recipe.Id);
                _repices.Remove(recipeToDelete);
            }

            public List<Recipe> GetAll()
            {
                return _repices;
            }

            public void Update(Recipe recipe)
            {
            Recipe recipeToUpdate = _repices.SingleOrDefault(p => p.Id == recipe.Id);
            recipeToUpdate.Name = recipe.Name;
            recipeToUpdate.Description = recipe.Description;
            recipeToUpdate.CategoryId = recipe.CategoryId;
            }
        }
    
}

