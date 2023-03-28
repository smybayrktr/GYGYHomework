using System;
using SolidPrinciplesExample.Business.Abstract;
using SolidPrinciplesExample.DataAccess.EntityFramework.Abstract;
using SolidPrinciplesExample.Entities.Concrete;

namespace SolidPrinciplesExample.Business.Concrete
{
	public class CategoryManager:ICategoryService
	{
		ICategoryDal _categoryDal;

        /*
         * Buda Dependency Inversion Principle örneğidir. Sistemimiz
         * ICategoryDal nesnesine bağımlıdır. Onu oluşturmaz dışarıdan alır.
         * EfCategoryDal ve InMemoryDal da bir ICategoryDal nesnesi olduğu için
         * tercihe uygun kullanılır.
         */
		public CategoryManager(ICategoryDal categoryDal)
		{
			_categoryDal = categoryDal;
		}

        public void Add(Category category)
        {
            _categoryDal.Add(category);
        }

        public void CategoryFilter()
        {
            _categoryDal.CategoryFilter();
        }

        public void Delete(Category category)
        {
            _categoryDal.Delete(category);
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }

        public void Update(Category category)
        {
            _categoryDal.Update(category);
        }
    }
}

