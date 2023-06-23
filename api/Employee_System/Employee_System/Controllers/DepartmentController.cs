using Employee_System.Models.Models;
using Employee_System.Services.Interfaces;
using Employee_System.Services.Services;
using Microsoft.AspNetCore.Mvc;

namespace Employee_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentService _departmentService;

        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Department>>> GetAllDepartments()
        {
            var result = await _departmentService.GetDepartments();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Department>> GetDepartment(int id)
        {
            var result = await _departmentService.GetDepartment(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<Department>>> AddDepartment (Department department)
        {
            var result = await _departmentService.AddDepartment(department);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<Department>>> UpdateDepartment (Department department)
        {
            var result = await _departmentService.UpdateDepartment(department.Id, department);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Department>> DeleteDepartment (int id)
        {
            var result = await _departmentService.DeleteDepartment(id);
            return Ok(result);
        }
    }
}
