using Domain.Models;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class ProductServices : IProductService
    {
        private readonly List<Product> products = new List<Product>();
        private Product[] GetAll()
        {
            Product[] products = new Product[]
           {
                new Product { Id = 1, Name = "Iphone 13", Price = 2500,CreatedDate=new (2023,05,01), Category=new Category{Id=11,Name="Telephone" }, },
                new Product { Id = 2, Name = "Iphone 12", Price = 1900,CreatedDate=new (2023,02,01), Category=new Category{Id=11,Name="Telephone" }, },
                new Product { Id = 3, Name = "Samsung Laptop", Price = 2000,CreatedDate=new (2023,06,02),Category = new Category{ Id=12,Name="Laptop"} },
                new Product { Id = 4, Name = "Samsung S90C", Price = 1500,CreatedDate=new (2023,07,04),Category=new Category{ Id=13, Name="Television"} },
                 
           };
            return products;
        }

        public List<Product> GetAllProducts()
        {
            return products;
        }
        public int GetCount()
        {
            Product[] products = GetAll();
            int count = products.Length;
            return count;

        }


        public Product[] SearchByText(string text)
        {
            Product[] products = GetAll();

            Product[] resProduct = products.Where(x => x.Name.ToLower().Trim().Contains(text.ToLower().Trim())).ToArray();
            return resProduct;
        }

        public Product[] AllProducts() => GetAll();

        public decimal avarageOfPrice() => GetAll().Sum(x => x.Price);


        public Product[] sortProducts()
        {
            Product[] products = GetAll();
            Product[] result = products.OrderByDescending(m => m.CreatedDate).ToArray();
            return result;
            
        }

        public Product[] searchByCategory( string categoryText)
        {
            Product[] products = GetAll();
            Product[] searchProductsCategory = products.Where(m => m.Category.Name.ToLower().Trim().Contains(categoryText.ToLower().Trim())).ToArray();
            return searchProductsCategory;
        }
       
        public List<Category> AllCategories()
        {
            List<Category> categories = new List<Category>();
            foreach (Product product in GetAll())
            {
                categories.Add(product.Category);       
            }
           return categories;
        }


        public Product[] GetByCategoriesId(int id)
        {

            Product[] products = GetAll();
            Product[] result=products.Where(x => x.Category.Id == id).ToArray();
            return result;

        }
    }

  
}
