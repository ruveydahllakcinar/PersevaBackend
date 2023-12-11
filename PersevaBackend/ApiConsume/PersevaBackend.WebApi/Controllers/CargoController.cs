using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersevaBackend.BusinessLayer.Abstract;
using PersevaBackend.EntityLayer.Concrete;

namespace PersevaBackend.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CargoController : ControllerBase
    {
        private readonly ICargoService _cargoService;

        public CargoController(ICargoService cargoService)
        {
            _cargoService = cargoService;
        }

        [HttpGet]
        public IActionResult CargoList()
        {
            var values = _cargoService.TGetList();
            return Ok(values);
        }

        [HttpPost("addnewcargo")]
        public IActionResult AddNewCargo(Cargo cargo)
        {
            _cargoService.TInsert(cargo);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateCargo()
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteCargo()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetCargoDetails()
        {
            return Ok();
        }

        [HttpPost("createtrackingnumber")]       
        public IActionResult CreateTrackingNumber(Cargo cargo)
        {
            _cargoService.TInsert(cargo);
            return Ok();
        }
    }
}

