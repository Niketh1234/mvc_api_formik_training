using ProductApi.Models;

namespace ProductApi.Services
{
    public class ProductService
    {
        private readonly ProductContext _context = new ProductContext();
        public List<Product> GetAllProducts()
        {
            return _context.Products.ToList();
        }
        public bool AddProduct(Product p)
        {
            try
            {
                _context.Products.Add(p);
                _context.SaveChanges();

                return true;
            }
            catch {
                return false;
            }
        }
        public bool UpdateProduct(int id,Product p)
        {
           var productId = _context.Products.Find(id);
            if (productId != null) {
                productId.StoreId = p.Id;
                productId.Name = p.Name;
                productId.Price = p.Price;
                productId.Image = p.Image;
                _context.SaveChanges();
                return true;
            }
            return false;
        }
        public bool DeleteProduct(int id)
        {
            var productId = _context.Products.Find(id);
            if (productId != null)
            {
               _context.Products.Remove(productId);
                _context.SaveChanges();
                return true;
            }
            return false;

        }
    }
}
