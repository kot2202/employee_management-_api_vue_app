using Employee_System.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_System.Services.Interfaces
{
    public interface IEmployeeService
    {
        List<Employee> GetEmployees();
        Employee GetEmployee(int id);
        List<Employee> AddEmployee(Employee department);
        List<Employee> UpdateEmployee(int id, Employee department);
        List<Employee> DeleteEmployee(int id);
    }
}
