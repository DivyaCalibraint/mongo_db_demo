using mongo_demo.DbConnection.Model;
using mongo_demo.Repository.Interface;
using mongo_demo.Services.Interface;

namespace mongo_demo.Services
{
    public class EmployeeService : IEmployeeService
    {
        public IEmployeeRepository employeeRepository;

        public EmployeeService(IEmployeeRepository _employeeRepository)
        {
            employeeRepository = _employeeRepository;
        }

        public async Task CreateEmployee(Employee employee)
        {
            await employeeRepository.CreateEmployee(employee);
        }

        public async Task DeleteEmployee(Guid Id)
        {
            await employeeRepository.DeleteEmployee(Id);
        }

        public async Task<List<Employee>> GetAllEmployees()
        {
            return await employeeRepository.GetAllEmployee();
        }

        public async Task<Employee> GetEmployeeById(Guid Id)
        {
            return await employeeRepository.GetEmployeeById(Id);
        }

        public Task UpdateEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
 