namespace ecommerce.Model
{
    public class Product_Category
    {
        public int productId { get; set; }
        public Product Product { get; set; }
        public int categoryId { get; set; }
        public Categories Category { get; set; }


    }
}
