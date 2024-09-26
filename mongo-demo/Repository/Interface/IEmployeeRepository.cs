using mongo_demo.DbConnection.Model;

namespace mongo_demo.Repository.Interface
{
    public interface IEmployeeRepository
    {
        Task<List<Employee>> GetAllEmployee();

        Task CreateEmployee(Employee employee);

        Task DeleteEmployee(Guid Id);

        Task<Employee> GetEmployeeById(Guid Id);
    }
}
