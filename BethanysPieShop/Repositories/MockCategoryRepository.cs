using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BethanysPieShop.Interfaces;
using BethanysPieShop.Models;

namespace BethanysPieShop.Repositories
{
    public class MockCategoryRepository: ICategoryRepository
    {
        public IEnumerable<Category> AllCategories => 
            new List<Category>
            {
                new Category{CategoryId = 1, Name = "Fruit Pies", Description = "All-fruity pies"},
                new Category{CategoryId = 2, Name = "Cheese Cakes", Description = "Cheesy all the way"},
                new Category{CategoryId = 3, Name = "Seasonal Pies", Description = "Get in the mood for a seasonal pie"}
            };
    }
}
