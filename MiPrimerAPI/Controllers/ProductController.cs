using Microsoft.AspNetCore.Mvc;
using MiPrimerAPI.Models;
using MiPrimerAPI.Services;

namespace MiPrimerAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ProductService _service;

        public ProductController(ProductService service)
        {
            _service = service;
        }

        // GET: api/Product
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var products = await _service.GetProductsAsync();
            return Ok(products);
        }

        // GET: api/Product/1
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var product = await _service.GetProductByIdAsync(id);
            if (product == null)
            {
                return NotFound($"No se encontró el producto con ID {id}");
            }
            return Ok(product);
        }

        // POST: api/Product
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Product product)
        {
            await _service.CreateProductAsync(product);
            return CreatedAtAction(nameof(GetById), new { id = product.Id }, product);
        }
    }
}