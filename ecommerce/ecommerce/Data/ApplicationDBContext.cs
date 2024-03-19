using ecommerce.Model;
using Microsoft.EntityFrameworkCore;


namespace ecommerce.Data
{
    public class ApplicationDBContext :DbContext
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        { }


        public DbSet<Product> Product { get; set; }
        public DbSet<Categories> Category { get; set; }

        public DbSet<Product_Category> Product_Categories { get; set; }



        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<Product_Category>(x => x.HasKey(p => new { p.productId, p.categoryId }));
            builder.Entity<Product_Category>().HasOne(p => p.Product).WithMany(p => p.Product_Categories).HasForeignKey(p => p.productId);
            builder.Entity<Product_Category>().HasOne(p => p.Category).WithMany(p => p.Product_Categories).HasForeignKey(p => p.categoryId);
            base.OnModelCreating(builder);
        }


    }
}
