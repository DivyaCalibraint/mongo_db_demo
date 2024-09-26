using mongo_demo.DbConnection.Model;

namespace mongo_demo.Services.Interface
{
    public interface IEmployeeService
    {
        Task<List<Employee>> GetAllEmployees();

        Task CreateEmployee(Employee employee);

        Task DeleteEmployee(Guid Id);

        Task<Employee> GetEmployeeById(Guid Id);
    }
}
