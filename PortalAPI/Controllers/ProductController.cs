using Microsoft.AspNetCore.Mvc;
using PortalAPI.Interface;
using PortalAPI.Model;

namespace PortalAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private IProductData _productData;
        public ProductController(ILogger<WeatherForecastController> logger, IProductData productData)
        {
            _productData = productData;
        }
        [HttpGet("{id}", Name = "GetProduct")]
        public ActionResult<Products> GetProduct(int id)
        {
            var product = _productData.GetProduct(id);

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }
    }
}
