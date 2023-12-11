using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersevaBackend.BusinessLayer.Abstract;
using PersevaBackend.EntityLayer.Concrete;

namespace PersevaBackend.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public IActionResult CategoryList()
        {
            var values = _categoryService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            _categoryService.TInsert(category);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateCategory()
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteCategory()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetCategory()
        {
            return Ok();
        }
    }
}
