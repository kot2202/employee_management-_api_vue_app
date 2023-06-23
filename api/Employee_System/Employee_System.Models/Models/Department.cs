using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_System.Models.Models
{
    [Table("Departments")]
    public class Department
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter the department name")]
        [MinLength(2)]
        [MaxLength(64)]
        public string Name { get; set; } = String.Empty;
    }
}
