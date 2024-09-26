using mongo_demo.DbConnection.Model;
using MongoDB.Driver;

namespace mongo_demo.DbConnection
{
    public class DbContext
    {
        public readonly IMongoCollection<Employee> empCollection;
        public DbContext(IConfiguration configuration)
        {
            MongoClient client = new MongoClient(configuration["ConnectionStrings:Connection_name"]);
            IMongoDatabase database = client.GetDatabase(configuration["ConnectionStrings:Database_name"]);
            empCollection = database.GetCollection<Employee>(configuration["ConnectionStrings:Collection_name"]);
        }
    }
}
