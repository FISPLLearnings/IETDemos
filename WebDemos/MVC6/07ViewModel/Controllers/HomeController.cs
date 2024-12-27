using _07ViewModel.Models;
using Microsoft.AspNetCore.Mvc;

namespace _07ViewModel.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ProductViewModel productViewModel = new ProductViewModel() 
            {
                Product = new Product() { Id=101,Name="Laptop",Price= 75000},
                CategoryName="Electronics",
                isInStock= false,
                Message="Company: Asus,i7 gen,RAM: 16GB"
            };
            return View(productViewModel);
        }
        public IActionResult Test(Product p)
        {
            return View(p);
        }
        public IActionResult ProductDeatils(int id)
        {
            Product product = new Product() { Id = 101, Name = "Laptop", Price = 75000 };
            return View(product);
        }
    }
}
