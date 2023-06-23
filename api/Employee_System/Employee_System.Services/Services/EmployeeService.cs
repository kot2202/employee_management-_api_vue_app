using Employee_System.Models.Models;
using Employee_System.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_System.Services.Services
{
    public class EmployeeService : IEmployeeService
    {
        private List<Employee> employees = new List<Employee>()
        {
            new Employee{
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                PhoneNumber = "123456789",
                Address = "123 Main St",
                Email = "john@doe.com",
                DateOfBirth = new DateTime(1990, 1, 1),
                DepartmentId = 1
            },
            new Employee
            {
                Id = 2,
                FirstName = "Jane",
                LastName = "Doe",
                PhoneNumber = "987654321",
                Address = "321 Main St",
                Email = "jane@doe.com",
                DateOfBirth = new DateTime(1995, 1, 1),
                DepartmentId = 2
            }
        };

        public List<Employee> AddEmployee(Employee employee)
        {
            employees.Add(employee);
            return employees;
        }

        public List<Employee> DeleteEmployee(int id)
        {
            var result = employees.Find(x =>x.Id == id);
            if (result == null)
            {
                return null;
            }

            employees.Remove(result);
            return employees;
        }

        public Employee GetEmployee(int id)
        {
            var result = employees.Find(x => x.Id == id);
            return result;
        }

        public List<Employee> GetEmployees()
        {
            var result = employees;
            return result;
        }

        public List<Employee> UpdateEmployee(int id, Employee employee)
        {
            var result = employees.Find(x => x.Id == id);
            if (result == null)
            {
                return null;
            }

            result.FirstName = employee.FirstName;
            result.LastName = employee.LastName;
            result.PhoneNumber = employee.PhoneNumber;
            result.Address = employee.Address;
            result.Email = employee.Email;
            result.DateOfBirth = employee.DateOfBirth;
            result.DepartmentId = employee.DepartmentId;
            result.DateOfJoin = employee.DateOfJoin;
            return employees;
        }
    }
}
