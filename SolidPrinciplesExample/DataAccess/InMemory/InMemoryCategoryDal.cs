using System;
using SolidPrinciplesExample.DataAccess.EntityFramework.Abstract;
using SolidPrinciplesExample.Entities.Concrete;

namespace SolidPrinciplesExample.DataAccess.InMemory
{
    /*
     * Sistemimiz bellek(liste) üzerine kaydederken entity frameworke geçirmeye karar verdik.
     * Bu senaryoda InMemoryCategoryDal'da EfCategoryDal'da aslında ICategoryDal nesnesi olduğu
     * için herhangi bir sorun yaşamadan geçirdik. Örneği program.cs de.
     * Bu senaryo Open Closed Principle yapısına da uygun bir örnektir.
     * Interface kullanarak HİÇBİR ŞEY DEĞİŞTİRMEDEN YENİ ÖZELLİK EKLEDİK.
     */

    //Listeler üzerinde ekleme-silme-güncelleme ve listeleme yapan sınıf.
    public class InMemoryCategoryDal:ICategoryDal
	{
        List<Category> _categories;

        public InMemoryCategoryDal()
        {
            _categories = new List<Category>
            {
                new Category{ Id=1, Name="Ana Yemek"},
                new Category{ Id=2, Name="Tatlı"},
                new Category{ Id=3, Name="Çorba"},
                new Category{ Id=4, Name="Aparatif" }
            };
        }

        public void Add(Category category)
        {
            _categories.Add(category);
        }

        public void CategoryFilter()
        {
            Console.WriteLine("Kategoriler Listelendi");
        }

        public void Delete(Category category)
        {
            Category categoryToDelete = _categories.SingleOrDefault(p => p.Id == category.Id);
            _categories.Remove(categoryToDelete);
        }

        public List<Category> GetAll()
        {
            return _categories;
        }

        public void Update(Category category)
        {
            Category categoryToUpdate = _categories.SingleOrDefault(p => p.Id == category.Id);
            categoryToUpdate.Name = category.Name;
        }
    }
}

