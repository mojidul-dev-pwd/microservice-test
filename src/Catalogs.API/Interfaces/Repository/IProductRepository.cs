using Catalogs.API.Models;
using MongoRepo.Interfaces.Repository;

namespace Catalogs.API.Interfaces.Repository
{
    public interface IProductRepository: ICommonRepository<Product>
    {
    }
}
