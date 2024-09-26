using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using mongo_demo.DbConnection.Model;
using mongo_demo.Repository.Interface;
using mongo_demo.Services.Interface;

namespace mongo_demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public IEmployeeService employeeService;

        public EmployeeController(IEmployeeService _employeeService)
        {
            employeeService = _employeeService;
        }

        [HttpGet("all/employees")]
        public async Task<ActionResult> GetEmployees()
        {
            var result = await employeeService.GetAllEmployees();
            return Ok(result);
        }

        [HttpPost("create")]
        public async Task<ActionResult> CreateEmployee([FromBody] Employee employee)
        {
            await employeeService.CreateEmployee(employee);
            return NoContent();
        }

        [HttpDelete("delete")]
        public async Task<ActionResult> DeleteEmployee(Guid Id)
        {
            var employee = await employeeService.GetEmployeeById(Id);
            if (employee != null)
            {
                await employeeService.DeleteEmployee(Id);
                return NoContent();
            }
            else
            {
                return BadRequest("Data not found");
            }
        }
    }
}
