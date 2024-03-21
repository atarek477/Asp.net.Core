using ecommerce.Data;
using ecommerce.Dto;
using ecommerce.Interfaces;
using ecommerce.Mapper;
using ecommerce.Model;
using Microsoft.EntityFrameworkCore;

namespace ecommerce.Repository

{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDBContext _dbContext;


        public ProductRepository(ApplicationDBContext dBContext)
        {
            _dbContext = dBContext;
        }

        public async Task<Product> CreateProduct(ProductDto productDto)
        {
            var product = productDto.ToProduct();
            await _dbContext.Product.AddAsync(product);
            await _dbContext.SaveChangesAsync();    
            return product;
        }

       

        public async Task<List<Product>> GetAllProduct()
        {
            var products= await _dbContext.Product.ToListAsync();
            if(products.Count == 0) { return null; }

            return products;
            
        }
 
        public async Task<Product> GetById(int id)
        {
            var product = await _dbContext.Product.FindAsync(id);
            if (product == null) { return null; }
            return product;
        }
        public async Task<Product> DeleteProduct(int id)
        {
            var product = await _dbContext.Product.FirstOrDefaultAsync(x=>x.id==id);
            if (product == null) { return null; }
            _dbContext.Product.Remove(product);
            await _dbContext.SaveChangesAsync();
            return product;
        }

        public async Task<Product> UpdateProduct(int id ,ProductDto productDto)
        {
            var product = await _dbContext.Product.FirstOrDefaultAsync(x=>x.id==id);

            if (product == null) { return null;}

            product.name=productDto.name;
            await _dbContext.SaveChangesAsync();    
            return product;




        }
    }
}
