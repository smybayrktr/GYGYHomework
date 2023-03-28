using System;
using SolidPrinciplesExample.Entities.Concrete;

namespace SolidPrinciplesExample.Business.Abstract
{
	public interface IRecipeService
	{
        List<Recipe> GetAll();
        void Add(Recipe recipe);
        void Delete(Recipe recipe);
        void Update(Recipe recipe);
    }
}

