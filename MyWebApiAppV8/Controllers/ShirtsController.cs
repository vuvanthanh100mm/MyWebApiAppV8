using Microsoft.AspNetCore.Mvc;
using MyWebApiAppV8.Models;

namespace MyWebApiAppV8.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShirtsController : ControllerBase
    {
        [HttpGet]
        public string GetShirts()
        {
            return "Reading all the shirts";
        }

        [HttpGet("{id}")]
        public string GetShirtById2(int id)
        {
            return $"Reading all the shirts: {id}";
        }

        /*[HttpGet("{id}")]
        public string GetShirtById2(int id, [FromQuery] string color)
        {
            return $"Reading all the shirts: {id}, {color}";
        }

        [HttpGet("{id}")]
        public string GetShirtById(int id, [FromHeader(Name ="Color")] string color)
        {
            return $"Reading all the shirts: {id}, {color}";
        }*/

        [HttpPost]
        public string CreateShirts([FromBody] Shirt shirt)
        {
            return $"Creating a  shirts";
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
