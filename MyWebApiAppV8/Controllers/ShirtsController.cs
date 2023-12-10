using Microsoft.AspNetCore.Mvc;
using MyWebApiAppV8.Models;

namespace MyWebApiAppV8.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShirtsController : ControllerBase
    {
        private List<Shirt> shirts = new List<Shirt>()
        {
            new Shirt {ShirtId=1, Brand = "My Brand", Color= "Blue", Gender= "Men", Price=30, Size=10 },
            new Shirt {ShirtId=2, Brand = "My Brand", Color= "Black", Gender= "Men", Price=35, Size=12 },
            new Shirt {ShirtId=3, Brand = "Your Brand", Color= "Orange", Gender= "Women", Price=28, Size=8 },
            new Shirt {ShirtId=4, Brand = "Your Brand", Color= "Yellow", Gender= "Women", Price=30, Size=9 }
        };

        [HttpGet]
        public IActionResult GetShirts()
        {
            return Ok("Reading all the shirts");
        }

        [HttpGet("{id}")]
        public IActionResult GetShirtById(int id)
        {
            if(id<0)
            {
                return BadRequest();
            }
            // return shirts.First(x => x.ShirtId == id);
            var shirt = shirts.FirstOrDefault(x => x.ShirtId == id);
            if(shirt == null)
            {
                return NotFound();
            }
            return Ok(shirt);
        }

        [HttpPost]
        public IActionResult CreateShirts([FromBody] Shirt shirt)
        {
            return Ok("Creating a shirts");
        }

        [HttpPut("{id}")]
        public string UpdateShirtById(int id)
        {
            return $"Updating all the shirts: {id}";
        }

        [HttpDelete("{id}")]
        public string DeleteShirtById(int id)
        {
            return $"Deleting all the shirts: {id}";
        }
    }
}
