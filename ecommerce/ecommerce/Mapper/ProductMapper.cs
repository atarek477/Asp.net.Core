using ecommerce.Dto;
using ecommerce.Model;

namespace ecommerce.Mapper
{
    public static class ProductMapper
    {
        public static ProductDto ToProductDto(this Product product) {

            return new ProductDto
            {

                name = product.name


            };
        
        
        
        
        }
        public static Product ToProduct(this ProductDto product)
        {

            return new Product
            {

                name = product.name


            };




        }


    }
}
