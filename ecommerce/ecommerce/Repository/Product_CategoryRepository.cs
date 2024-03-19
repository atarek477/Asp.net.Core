using ecommerce.Data;
using ecommerce.Interfaces;
using ecommerce.Model;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ecommerce.Dto;
using ecommerce.Mapper;

namespace ecommerce.Repository
{
    public class Product_CategoryRepository : IProduct_Category
    {
        private readonly ApplicationDBContext dbContext;

        public Product_CategoryRepository(ApplicationDBContext _dbContext)
        {
            dbContext = _dbContext;
            
        }

        public async Task<List<ResultDto>> GetAllByPNameOrCName(string name)
        {
            var query = from productCategory in dbContext.Product_Categories
                        join category in dbContext.Category on productCategory.categoryId equals category.id
                        join product in dbContext.Product on productCategory.productId equals product.id
                        where name == null || product.name.Contains(name) || category.name.Contains(name)
                        select new { Product = product, Category = category };
            var result= await query.ToListAsync();
           if (result.Count == 0) { return null; }

           return result.Select(item=>item.Product.ToResult(item.Category)).ToList();
        }
    }
}
