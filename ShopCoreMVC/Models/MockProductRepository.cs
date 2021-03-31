using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopCoreMVC.Models
{
    public class MockProductRepository : IProductRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();
        public IEnumerable<Product> AllProducts =>
            new List<Product>
            {
                new Product{ ProductId = 1 , Name = "Pralka", ShortDescription="Praleczka pralkunia", LongDescription="Dłuższy opis praleczki pralkuni", Price=1500, ImageUrl=@"..\images\iphone.jpg", ImageThumbnailUrl=@"..\images\iphone.jpg", IsBestSeller=true, InStock=true, Category=_categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == "RTV"), CategoryId=1},
                new Product{ ProductId = 1 , Name = "Smart TV", ShortDescription="Elegancki Smarcik TV", LongDescription="Dłuższy opis smarcika TV", Price=2500, ImageUrl=null, ImageThumbnailUrl=null, IsBestSeller=true, InStock=true, Category=_categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == "RTV"), CategoryId=1}
            };

        public IEnumerable<Product> BestSellers { get; }

        public Product GetProductById(int productId)
        {
            return AllProducts.FirstOrDefault(p => p.ProductId == productId);
        }
    }
}
