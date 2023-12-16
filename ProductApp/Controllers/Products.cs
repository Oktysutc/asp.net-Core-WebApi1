using Microsoft.AspNetCore.Mvc;
using ProductApp.model;

namespace ProductApp.Controllers
{
    [Route("api/[products]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ILogger<ProductsController> _logger;// readnly birinci ctor ikinci tanımlandıgı yerdir
        
        public ProductsController(ILogger<ProductsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetAllProducts() {
            var products = new List<Product>()
            { new Product(){Id=1, ProductName="Computer"},
            new Product(){Id=2,ProductName="kyeboard"},
                new Product(){Id=3, ProductName="mouse"}

            };
            return Ok(products);
        }

    }
}
