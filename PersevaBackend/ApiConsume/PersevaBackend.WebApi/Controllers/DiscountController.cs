//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using PersevaBackend.BusinessLayer.Abstract;
//using PersevaBackend.EntityLayer.Concrete;

//namespace PersevaBackend.WebApi.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class DiscountController : ControllerBase
//    {
//        private readonly IDiscountService _discountService;

//        public DiscountController(IDiscountService discountService)
//        {
//            _discountService = discountService;
//        }

//        [HttpGet]
//        public IActionResult DiscountCodeList()
//        {
//            var values = _discountService.TGetList();
//            return Ok(values);
//        }

//        [HttpPost]
//        public IActionResult CreateNewDiscount(Discount discount)
//        {
//            _discountService.TInsert(discount);
//            return Ok();
//        }

//        [HttpPut]
//        public IActionResult UpdateDiscountCode()
//        {
//            return Ok();
//        }

//        [HttpDelete]
//        public IActionResult DeleteDiscountCode()
//        {
//            return Ok();
//        }

//        [HttpGet("{id}")]
//        public IActionResult GetDiscountCode()
//        {
//            return Ok();
//        }
//    }
//}