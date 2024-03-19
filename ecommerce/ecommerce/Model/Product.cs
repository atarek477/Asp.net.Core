using System.ComponentModel.DataAnnotations;

namespace ecommerce.Model
{
    public class Product
    {
        public int id { get; set; }
        
 
        public string name { get; set; }

        public List<Product_Category> Product_Categories { get; set; } = new List<Product_Category>();




    }
}
