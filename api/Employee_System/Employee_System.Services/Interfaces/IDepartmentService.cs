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
        List<Department> GetDepartments();
        Department GetDepartment(int id);
        List<Department> AddDepartment(Department department);
        List<Department> UpdateDepartment(int id, Department department);
        List<Department> DeleteDepartment(int id);
    }
}
