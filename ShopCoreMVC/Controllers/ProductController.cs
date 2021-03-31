using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShopCoreMVC.Models;
using ShopCoreMVC.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShopCoreMVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;
        public ProductController(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }
        public ViewResult ListOfProducts()
        {
            ProductListViewModel productListViewModel = new ProductListViewModel();
            productListViewModel.Products = _productRepository.AllProducts;
            productListViewModel.CurrentCategory = "Produkty z wszystkich kategorii";

            return View(productListViewModel);
        }
    }
}
