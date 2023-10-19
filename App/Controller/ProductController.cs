using Domain.Models;
using Service.Services;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Controller
{
    internal class ProductController
    {
      public readonly IProductService _productService;
        public ProductController()
        {
            _productService =new  ProductServices();
        }

        public void GetAll()
        {
            Console.WriteLine(_productService.GetCount());
        }
        public void SearchByText()
        {

            Console.WriteLine("Add search text:");

        SearchText: string searchText = Console.ReadLine();

            if (string.IsNullOrEmpty(searchText))
            {
                Console.WriteLine("Please add text");
                goto SearchText;
            }

            foreach (var product in _productService.SearchByText(searchText))
            {
                Console.WriteLine($"{product.Name}-{product.Price}-{product.CreatedDate}");
            }          
        }

        public void AllProducts()
        {
            var result=_productService.AllProducts();
            foreach (var product in result)
            {
                Console.WriteLine($"Product's Name:{product.Name}-Product's Price:{product.Price}-Product's CreatDate:{product.CreatedDate}-Product's Category:{product.Category.Name}");
            }

        }
        public void AvarageOfPrice()
        {
          var result=_productService.avarageOfPrice()/_productService.AllProducts().Length;
          Console.WriteLine(result);
        }

        public void SortProducts()
        {
            var res=_productService.sortProducts();
            foreach (var product in res)
            {
                Console.WriteLine($"{product.Name}-{product.CreatedDate}");
            }
        }

        public void SearchByCategory()
        {
            Console.WriteLine("Add Category's name");
            string categoryText=Console.ReadLine();
            foreach(var product in _productService.searchByCategory(categoryText))
            {
                Console.WriteLine($"{product.Name}-{product.Category.Name}");
            }

        }
        public void AllCategories()
        {
            var result = _productService.AllCategories();
            foreach(var category in result)
            {
                Console.WriteLine($"{category.Name}");
            }
        }

        public void GetById()
        {
            int id = 11;
          
            foreach (var product in _productService.GetByCategoriesId(id))
            {
                Console.WriteLine($"{product.Category.Name}-{product.Name}-{product.Price}");
            }
        }
            
    
    }
}
