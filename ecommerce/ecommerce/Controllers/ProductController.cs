using ecommerce.Dto;
using ecommerce.Interfaces;
using ecommerce.Mapper;
using ecommerce.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ecommerce.Controllers
{
    [Route("api/product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly   IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository; 
        }



        [HttpGet]
        public async Task<IActionResult> GetAll() {

            var products = await _productRepository.GetAllProduct();
            if (products == null) { return BadRequest("there is no products"); }
            var result= products.Select(x => x.ToProductDto()).ToList();
            return Ok(result);
        
        
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetById([FromRoute]int id)
        {

            var product = await _productRepository.GetById(id);
            if (product == null) { return BadRequest("there is no product with this id "); }
            
            return Ok(product.ToProductDto());


        }



        [HttpPost]
        public async Task<IActionResult> CreateProduct([FromBody]ProductDto productDto)
        {

            var product = await _productRepository.CreateProduct(productDto);
          
            return Ok(product.ToProductDto());


        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {

            var product = await _productRepository.DeleteProduct(id);
            if (product == null) { return BadRequest("there is no product with this id "); }

            return Ok(NoContent());


        }



    }
}
