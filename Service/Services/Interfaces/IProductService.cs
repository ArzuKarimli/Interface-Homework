using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Interfaces
{
    public interface IProductService
    {
        int GetCount();
        Product[] SearchByText(string text);
        Product[] AllProducts();
        decimal avarageOfPrice();
        Product[] sortProducts();
        Product[] searchByCategory(string categoryText);
        List<Category> AllCategories();
        Product[] GetByCategoriesId(int id);


    }
}
