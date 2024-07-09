using MongoRepo.Context;

namespace Catalogs.API.context
{
    public class CatalogDbContext : ApplicationDbContext
    {
        static IConfiguration configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: true, reloadOnChange: true).Build();
        //static string connectionString = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json",optional:true,reloadOnChange:true).Build().GetConnectionString("Catalog.API");
        static string connectionString = configuration.GetConnectionString("Catalog.API");
        static string databaseName = configuration.GetValue<string>("DatabaseName");
        public CatalogDbContext() : base(connectionString, databaseName)
        {
        }
    }
}
