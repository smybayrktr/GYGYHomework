using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SolidPrinciplesExample.Entities.Concrete;

namespace SolidPrinciplesExample.DataAccess.EntityFramework
{
	public class RecipeWebContext: DbContext
	{
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; Database=RecipesWebDb; Trusted_Connection=true");
        }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}

