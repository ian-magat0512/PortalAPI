using PortalAPI.Data;
using PortalAPI.Interface;
using PortalAPI.Model;

namespace PortalAPI.Repository
{
    public class ProductRepository : IProductData
    {
        private readonly DataContext _context;

        public ProductRepository(DataContext context)
        {
            _context = context;
        }

        public Products GetProduct(int id)
        {
            return _context.Products.FirstOrDefault(p => p.Id == id); 
        }
    }
}
