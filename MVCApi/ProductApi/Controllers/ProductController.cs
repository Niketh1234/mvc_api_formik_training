using Microsoft.AspNetCore.Mvc;
using ProductApi.Models;
using ProductApi.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        // GET: api/<ProductController>
        private readonly ProductService _productService = new ProductService();

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return  _productService.GetAllProducts();
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProductController>
        [HttpPost]
        public IActionResult Post([FromBody] Product value)
        {

            if(_productService.AddProduct(value))
                return Ok();
            return BadRequest();
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Product value)
        {
            if (_productService.UpdateProduct(id, value))
                return Ok();
            return BadRequest();
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
           if(_productService.DeleteProduct(id))
                return Ok();
           return BadRequest();
        }
    }
}
