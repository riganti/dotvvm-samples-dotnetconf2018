using DotNetConfDemo2.Model;

namespace DotNetConfDemo2.Services
{
    public class ProductOrderService
    {
        private readonly AppDbContext dbContext;

        public ProductOrderService(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Reorder(int productId, int unitsToReorder)
        {
            var product = dbContext.Products.Find(productId);
            product.UnitsOnOrder += (short)unitsToReorder;
            dbContext.SaveChanges();
        }
    }
}
