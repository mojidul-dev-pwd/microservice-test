using Catalogs.API.Models;
using MongoRepo.Interfaces.Manager;

namespace Catalogs.API.Interfaces.Manager
{
    public interface IProductManager : ICommonManager<Product>
    {
        public List<Product> GetByCategory(string category);
    }
}
