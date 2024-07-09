using Catalogs.API.context;
using Catalogs.API.Interfaces.Repository;
using Catalogs.API.Models;
using MongoRepo.Repository;

namespace Catalogs.API.Repository
{
    public class ProductRepository: CommonRepository<Product>, IProductRepository
    {
        public ProductRepository() : base(new CatalogDbContext())
    {
    }
}
}
