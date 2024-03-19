using ecommerce.Helper;
using ecommerce.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ecommerce.Mapper;

namespace ecommerce.Controllers
{
    [Route("api/product_category")]
    [ApiController]
    public class Product_CategoryController : ControllerBase
    {
        private readonly IProduct_Category repository;
        public Product_CategoryController(IProduct_Category _repository)
        {
            repository = _repository;

        }

        [HttpGet]
        public async Task<IActionResult> SearchByName([FromQuery] QueryObject query) {


            var list=await repository.GetAllByPNameOrCName(query.name);
            

            if (list == null) { return NotFound("there is no result"); }
              return Ok(list);
        
        }


    }
}
