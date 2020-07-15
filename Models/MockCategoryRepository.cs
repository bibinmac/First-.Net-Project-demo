using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanyPieShop.Models
{
    public class MockCategoryRepository: ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Fruit pies", Description="All Fruit pies"},
                new Category{CategoryId=2, CategoryName="Cheese pies", Description="Cheese All the Way"},
                new Category{CategoryId=3, CategoryName="Seasonal", Description="Get in Mood for seasonal"}
            };
    }
}
