using Microsoft.AspNetCore.Mvc;

namespace ProductsInJsonFormat.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : Controller
    {
        private static readonly List<Product> _products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Price = 100M},
            new Product { Id = 2, Name = "Fridge", Price =45M },
            new Product { Id = 3, Name = "Watch", Price = 55.99M }
        };
        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok(_products);
        }
    }
}


