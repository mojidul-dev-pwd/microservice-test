using Catalogs.API.Interfaces.Manager;
using Catalogs.API.Models;
using Catalogs.API.Repository;
using MongoRepo.Manager;

namespace Catalogs.API.Manager
{
    public class ProductManager : CommonManager<Product>, IProductManager
    {
        public ProductManager() : base(new ProductRepository())
        {
        }

        public List<Product> GetByCategory(string category)
        {
            return GetAll(c => c.Category == category).ToList();
        }
    }
}
