using ecommerce.Dto;
using ecommerce.Model;

namespace ecommerce.Mapper
{
    public static class ProductCategoryMapper
    {
        public static ResultDto ToResult(this Product product, Categories category) 
        {
          return  new ResultDto
          {
                     ProductName = product.name,
                     CategoryName = category.name
          };
        }


    }
}
