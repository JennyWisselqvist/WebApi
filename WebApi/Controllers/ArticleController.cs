using Microsoft.AspNetCore.Mvc;
using WebApi.Controllers;
using WebApi.Models.DTO;
using WebApi.Services;


namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private readonly ProductService _products;
        public ArticleController(ProductService products)
        {
            _products = products;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _products.GetAllAsync());
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProductRegistrationModel model)
        {
            await _products.CreateAsync(model);
            return NoContent();
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}


