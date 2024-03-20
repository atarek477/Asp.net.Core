using ecommerce.Model;
using ecommerce.Dto;

namespace ecommerce.Interfaces
{
    public interface IProductRepository
    {



        Task<List<Product>> GetAllProduct();
        Task<Product> GetById(int id);  
        Task<Product>CreateProduct(ProductDto product);
        Task<Product> DeleteProduct(int id);



    }
}
