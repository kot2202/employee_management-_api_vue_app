using Employee_System.Migrations;
using Employee_System.Models.Models;
using Employee_System.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_System.Services.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly CompanyDbContext _dbContext;

        public EmployeeService(CompanyDbContext context)
        {
            _dbContext = context;
        }

        //private List<Employee> employees = new List<Employee>()
        //{
        //    new Employee{
        //        Id = 1,
        //        FirstName = "John",
        //        LastName = "Doe",
        //        PhoneNumber = "123456789",
        //        Address = "123 Main St",
        //        Email = "john@doe.com",
        //        DateOfBirth = new DateTime(1990, 1, 1),
        //        DepartmentId = 1
        //    },
        //    new Employee
        //    {
        //        Id = 2,
        //        FirstName = "Jane",
        //        LastName = "Doe",
        //        PhoneNumber = "987654321",
        //        Address = "321 Main St",
        //        Email = "jane@doe.com",
        //        DateOfBirth = new DateTime(1995, 1, 1),
        //        DepartmentId = 2
        //    }
        //};

        public async Task<List<Employee>> AddEmployee(Employee employee)
        {
            await _dbContext.Employees.AddAsync(employee);
            await _dbContext.SaveChangesAsync();
            return await _dbContext.Employees.ToListAsync();
        }

        public async Task<List<Employee>> DeleteEmployee(int id)
        {
            var result = await _dbContext.Employees.FindAsync(id);
            if(result == null)
            {
                return null;
            }

            _dbContext.Remove(result);
            await _dbContext.SaveChangesAsync();
            return await _dbContext.Employees.ToListAsync();
        }

        public async Task<Employee> GetEmployee(int id)
        {
            var result = await _dbContext.Employees.FindAsync(id);
            if (result == null)
            {
                return null;
            }
            return result;
        }

        public async Task<List<Employee>> GetEmployees()
        {
            var result = await _dbContext.Employees.ToListAsync();
            return result;
        }

        public async Task<List<Employee>> UpdateEmployee(int id, Employee employee)
        {
            var result = await _dbContext.Employees.FindAsync(id);
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

            await _dbContext.SaveChangesAsync();
            return await _dbContext.Employees.ToListAsync();
        }
    }
}
