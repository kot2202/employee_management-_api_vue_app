using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_System.Models.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter the department name")]
        [MinLength(3)]
        [MaxLength(64)]
        public string Name { get; set; } = String.Empty;
    }
}
