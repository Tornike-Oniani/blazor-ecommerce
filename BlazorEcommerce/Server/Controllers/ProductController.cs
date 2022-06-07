using Microsoft.AspNetCore.Mvc;

namespace BlazorEcommerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService) { this._productService = productService; }

        [HttpGet]
        [ProducesResponseType(typeof(ServiceResponse<IEnumerable<Product>>), 200)]
        public async Task<IActionResult> GetProducts()
        {
            var result = await _productService.GetProductsAsync();
            return Ok(result);
        }

        [HttpGet]
        [Route("{productId:int}")]
        [ProducesResponseType(typeof(ServiceResponse<Product>), 200)]
        public async Task<IActionResult> GetProduct(int productId)
        {
            var result = await _productService.GetProductAsync(productId);
            return Ok(result);
        }

    }
}
