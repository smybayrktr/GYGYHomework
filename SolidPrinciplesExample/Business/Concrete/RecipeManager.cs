using System;
using SolidPrinciplesExample.Business.Abstract;
using SolidPrinciplesExample.DataAccess.EntityFramework.Abstract;
using SolidPrinciplesExample.Entities.Concrete;

namespace SolidPrinciplesExample.Business.Concrete
{
	public class RecipeManager: IRecipeService
	{
		IRecipeDal _recipeDal;
		public RecipeManager(IRecipeDal recipeDal)
		{
			_recipeDal = recipeDal;
		}

        public void Add(Recipe recipe)
        {
            _recipeDal.Add(recipe);
        }

        public void Delete(Recipe recipe)
        {
            _recipeDal.Delete(recipe);
        }

        public List<Recipe> GetAll()
        {
            return _recipeDal.GetAll();
        }

        public void Update(Recipe recipe)
        {
            _recipeDal.Update(recipe);
        }
    }
}

