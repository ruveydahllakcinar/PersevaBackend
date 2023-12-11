//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using PersevaBackend.BusinessLayer.Abstract;
//using PersevaBackend.EntityLayer.Concrete;

//namespace PersevaBackend.WebApi.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class ReturnController : ControllerBase
//    {
//        private readonly IReturnService _returnService;

//        public ReturnController(IReturnService ReturnService)
//        {
//            _returnService = ReturnService;
//        }

//        [HttpGet]
//        public IActionResult ReturnList()
//        {
//            var values = _returnService.TGetList();
//            return Ok(values);
//        }


//        [HttpPut]
//        public IActionResult UpdateReturn()
//        {
//            return Ok();
//        }

//        [HttpDelete]
//        public IActionResult DeleteReturn()
//        {
//            return Ok();
//        }

//        [HttpGet("{id}")]
//        public IActionResult GetReturnDetails()
//        {
//            return Ok();
//        }
//    }
//}
 
