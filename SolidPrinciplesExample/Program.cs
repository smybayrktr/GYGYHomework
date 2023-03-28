using SolidPrinciplesExample.Business.Concrete;
using SolidPrinciplesExample.DataAccess.EntityFramework.Concrete;
using SolidPrinciplesExample.DataAccess.InMemory;


EntityFrameworkGetAllTest();
InMemoryGetAllTest();


static void EntityFrameworkGetAllTest()
{
    RecipeManager recipeManager = new RecipeManager(new EfRecipeDal());
    foreach (var item in recipeManager.GetAll())
    {
        Console.WriteLine(item.Name);
    }
}

static void InMemoryGetAllTest()
{
    RecipeManager recipeManager = new RecipeManager(new InMemoryRecipeDal());
    foreach (var item in recipeManager.GetAll())
    {
        Console.WriteLine(item.Name);
    }
}