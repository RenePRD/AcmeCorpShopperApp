using Microsoft.AspNetCore.Mvc;
using AcmeCorp.Shopper.UiWebApp.Models;

namespace AcmeCorp.Shopper.UiWebApp.Controllers
{
    public class LibraryController : Controller
    {
        public string Index()
        {
            return "Welcome to my Library!";
        }

        public IActionResult AllProducts()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product { ProductId = "1234567890", ProductName = "X", ProductPrice = new Decimal(999.999) });
            
            return View(products);
        }
    }
}
