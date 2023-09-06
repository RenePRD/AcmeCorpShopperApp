using AcmeCorp.Shopper.ProductsRestApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Eventing.Reader;

namespace AcmeCorp.Shopper.ProductsRestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ProductsAcmeContext _context;

        public ProductsController(ProductsAcmeContext context)
        {
            _context = context;
        }

        [HttpPost]
        public ActionResult<Product> CreateProduct([FromBody] Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return this.CreatedAtAction("ReadProductById", new { id = product.ProductId }, product);
        }

        [HttpGet]
        public ActionResult<IEnumerable<Product>> ReadAllProducts()
        {
            return this.Ok(_context.Products);
        }

        [HttpGet("{id}")]
        public ActionResult<Product> ReadProductById (int id)
        {
            var foundProduct = _context.Products.Find(id);
            if (object.ReferenceEquals(foundProduct, null))
            {
                return this.NotFound();
            }
            return this.Ok(foundProduct);
        }

        [HttpGet("name/{name}")]
        public ActionResult<Product> ReadProductByName(string name)
        {
            var foundProduct = _context.Products.Where(product => product.ProductName == name);
            if (object.ReferenceEquals(foundProduct, null))
            {
                return this.NotFound();
            }
            return this.Ok(foundProduct);
        }

        [HttpPut]
        public ActionResult<Product> UpdateProduct([FromBody] Product product)
        {
            var existingProduct = _context.Products.Find(product.ProductId);
            if (object.ReferenceEquals(existingProduct, null))
            {
                return this.NotFound();
            }
            existingProduct.ProductName = product.ProductName;
            existingProduct.ProductPrice = product.ProductPrice;
            _context.SaveChanges();
            return this.Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult<Product> DeleteProductById(int id)
        {
            var foundProduct = _context.Products.Find(id);
            if (object.ReferenceEquals(foundProduct, null))
            {
                return this.NotFound();
            }
            _context.Products.Remove(foundProduct);
            _context.SaveChanges();
            return this.Ok();
        }
    }
}
