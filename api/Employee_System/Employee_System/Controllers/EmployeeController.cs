using Employee_System.Models.Models;
using Employee_System.Services.Interfaces;
using Employee_System.Services.Services;
using Microsoft.AspNetCore.Mvc;

namespace Employee_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employee>>> GetAllEmployees()
        {
            var result = _employeeService.GetEmployees();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Employee>> GetEmployee(int id)
        {
            var result = _employeeService.GetEmployee(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<Employee>>> AddEmployee(Employee employee)
        {
            var result = _employeeService.AddEmployee(employee);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<Employee>>> UpdateEmployee(Employee employee)
        {
            var result = _employeeService.UpdateEmployee(employee.Id, employee);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Department>> DeleteDepartment (int id)
        {
            var result = _employeeService.DeleteEmployee(id);
            return Ok(result);
        }
    }
}
