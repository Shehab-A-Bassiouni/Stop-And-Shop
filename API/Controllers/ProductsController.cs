using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public string GetProducts() {
            return "This will be a list of products";
        }

        [HttpGet("{id}")]
        public string GetProduct(int id)
        {
            return "This will be a product";
        }
    }
}
