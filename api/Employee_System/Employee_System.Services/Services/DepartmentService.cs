using Employee_System.Models.Models;
using Employee_System.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_System.Services.Services
{
    public class DepartmentService : IDepartmentService
    {
        private List<Department> departments = new List<Department>()
        {
            new Department{ Id = 1, Name = "IT"},
            new Department{ Id = 2, Name = "HR"},
            new Department{ Id = 3, Name = "Finance"},
            new Department{ Id = 4, Name = "Sales"}
        };

        public List<Department> AddDepartment(Department department)
        {
            departments.Add(department);
            return departments;
        }

        public List<Department> DeleteDepartment(int id)
        {
            var result = departments.Find(x => x.Id == id);
            if(result == null)
            {
                return null;
            }

            departments.Remove(result);
            return departments;
        }

        public Department GetDepartment(int id)
        {
            var result = departments.Find(x => x.Id == id);
            return result;
        }

        public List<Department> GetDepartments()
        {
            var result = departments;
            return result;
        }

        public List<Department> UpdateDepartment(int id, Department department)
        {
            var result = departments.Find(x =>x.Id == id);
            if (result == null)
            {
                return null;
            }

            result.Name = department.Name;
            return departments;
        }
    }
}
