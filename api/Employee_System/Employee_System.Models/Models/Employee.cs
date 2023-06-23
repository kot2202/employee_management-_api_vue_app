using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_System.Models.Models
{
    [Table("Employees")]
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(16)]
        public string FirstName { get; set; } = String.Empty;

        [Required]
        [MinLength(2)]
        [MaxLength(32)]
        public string LastName { get; set; } = String.Empty;

        [MinLength(9)]
        [MaxLength(9)]
        public string PhoneNumber { get; set; } = String.Empty;

        [Required]
        [MinLength(3)]
        [MaxLength(64)]
        public string Address { get; set; } = String.Empty;

        [Required]
        [MinLength(6)]
        [MaxLength(64)]
        public string Email { get; set; } = String.Empty;

        public DateTime DateOfJoin { get; set; } = DateTime.UtcNow;

        public DateTime DateOfBirth { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }

    }
}
