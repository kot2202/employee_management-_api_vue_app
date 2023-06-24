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
