using ecommerce.Dto;
using ecommerce.Model;

namespace ecommerce.Mapper
{
    public static class CategoryMapper
    {
        public static Categories ToCategory(this CategoryDto category) {
            return new Categories
            {
                name = category.name



            };
        
        
        
        }

        public static CategoryDto ToCategoryDto(this Categories category)
        {
            return new CategoryDto
            {
                name = category.name



            };



        }



    }
}
