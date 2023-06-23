using Employee_System.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_System.Services.Interfaces
{
    public interface IDepartmentService
    {
        Task<List<Department>> GetDepartments();
        Task<Department> GetDepartment(int id);
        Task <List<Department>> AddDepartment(Department department);
        Task <List<Department>> UpdateDepartment(int id, Department department);
        Task <List<Department>> DeleteDepartment(int id);
    }
}
