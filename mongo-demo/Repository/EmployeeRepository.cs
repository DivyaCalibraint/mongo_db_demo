using mongo_demo.DbConnection;
using mongo_demo.DbConnection.Model;
using mongo_demo.Repository.Interface;
using MongoDB.Bson;
using MongoDB.Driver;

namespace mongo_demo.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public readonly DbContext dbContext;
        public EmployeeRepository(DbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public async Task CreateEmployee(Employee employee)
        {
            await dbContext.empCollection.InsertOneAsync(employee);
        }

        public async Task<List<Employee>> GetAllEmployee()
        {
            var data = await dbContext.empCollection.Find(_ => true).ToListAsync();
            return data;
        }

        public async Task DeleteEmployee(Guid Id)
        {
            await dbContext.empCollection.DeleteOneAsync(e => e.Id == Id);
        }

        public async Task<Employee> GetEmployeeById(Guid Id)
        {
            return await dbContext.empCollection.Find(e => e.Id == Id).FirstOrDefaultAsync();
        }
    }
}
