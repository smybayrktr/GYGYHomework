using System;
using SolidPrinciplesExample.Entities.Concrete;

namespace SolidPrinciplesExample.Business.Abstract
{
	public interface ICategoryService
	{
        List<Category> GetAll();
        void CategoryFilter();
        void Add(Category category);
        void Delete(Category category);
        void Update(Category category);
    }
}

