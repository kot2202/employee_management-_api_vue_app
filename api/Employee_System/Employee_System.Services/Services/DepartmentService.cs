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
    public class DepartmentService : IDepartmentService
    {
        private readonly CompanyDbContext _dbContext;

        public DepartmentService(CompanyDbContext context)
        {
            _dbContext = context;
        }

        //private List<Department> departments = new List<Department>()
        //{
        //    new Department{ Id = 1, Name = "IT"},
        //    new Department{ Id = 2, Name = "HR"},
        //    new Department{ Id = 3, Name = "Finance"},
        //    new Department{ Id = 4, Name = "Sales"}
        //};

        public async Task<List<Department>> AddDepartment(Department department)
        {
            await _dbContext.Departments.AddAsync(department);
            await _dbContext.SaveChangesAsync();

            return await _dbContext.Departments.ToListAsync();
        }

        public async Task<List<Department>> DeleteDepartment(int id)
        {
            var result = await _dbContext.Departments.FindAsync(id);
            if(result == null)
            {
                return null;
            }

            _dbContext.Remove(result);
            await _dbContext.SaveChangesAsync();
            return await _dbContext.Departments.ToListAsync();
        }

        public async Task<Department> GetDepartment(int id)
        {
            var result = await _dbContext.Departments.FindAsync(id);
            if (result == null)
            {
                return null;
            }
            return result;
        }

        public async Task<List<Department>> GetDepartments()
        {
            var result = await _dbContext.Departments.ToListAsync();
            return result;
        }

        public async Task<List<Department>> UpdateDepartment(int id, Department department)
        {
            var result = await _dbContext.Departments.FindAsync(id);
            if (result == null)
            {
                return null;
            }

            result.Name = department.Name;
            await _dbContext.SaveChangesAsync();
            return await _dbContext.Departments.ToListAsync();
        }
    }
}
