using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersevaBackend.BusinessLayer.Abstract;
using PersevaBackend.EntityLayer.Concrete;
using PersevaBackend.WebApi.Models;
using RestSharp;

namespace PersevaBackend.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("Batu")]
        public async Task<IActionResult> ProductListAsync()
        {
            RestResponse values = await _productService.GetShopierProductList();
            return Ok(values.Content);
        }

        [HttpPost]
        public IActionResult AddProduct(ProductRequest productRequest) 
        {
            _productService.TInsert(productRequest);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateProduct()
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteProduct()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            return Ok();
        }
    }
}
