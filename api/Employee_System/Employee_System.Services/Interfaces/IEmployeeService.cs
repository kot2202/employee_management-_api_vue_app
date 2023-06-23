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
        Task<List<Employee>> GetEmployees();
        Task<Employee> GetEmployee(int id);
        Task<List<Employee>> AddEmployee(Employee department);
        Task<List<Employee>> UpdateEmployee(int id, Employee department);
        Task<List<Employee>> DeleteEmployee(int id);
    }
}
