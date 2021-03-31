using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopCoreMVC.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{CategoryId=1, CategoryName="RTV", Description="Sprzęt RTV"},
                new Category{CategoryId=2, CategoryName="AGD", Description="Sprzęt AGD"}
            };
    }

}
