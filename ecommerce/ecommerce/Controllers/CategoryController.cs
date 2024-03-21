using ecommerce.Dto;
using ecommerce.Interfaces;
using ecommerce.Mapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ecommerce.Controllers
{
    [Route("api/category")]
    [ApiController]
    public class CategoryController : ControllerBase
    {

        private readonly ICategoryRepository _categoryRepository;
        public CategoryController(ICategoryRepository categotyRepository)
        {
            _categoryRepository = categotyRepository;
        }



        [HttpGet]
        public async Task<IActionResult> GetAll()
        {

            var categories = await _categoryRepository.GetAllCategories();
            if (categories== null) { return BadRequest("there is no categories"); }
            var result = categories.Select(x => x.ToCategoryDto()).ToList();
            return Ok(result);


        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {

            var category = await _categoryRepository.GetById(id);
            if (category == null) { return BadRequest("there is no category with this id "); }

            return Ok(category. ToCategoryDto());


        }



        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CategoryDto categoryDto)
        {

            var category = await _categoryRepository.CreateCategory(categoryDto);

            return Ok(category.ToCategoryDto());


        }


        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] CategoryDto categoryDto)
        {

            var category = await _categoryRepository.UpdateCategory(id, categoryDto);
            if (category == null) { return BadRequest("there is no category with this id "); }

            return Ok(category.ToCategoryDto());


        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {

            var category = await _categoryRepository.DeleteCategory(id);
            if (category == null) { return BadRequest("there is no category with this id "); }

            return Ok(NoContent());


        }



    }
}
