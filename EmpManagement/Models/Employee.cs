using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EmpManagement.Models
{
    public class Employee
    {
        [Display(Name = "Employee Id")]
        [Key]
        public int Eid { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Name cannot xceed 50")]
        public string Name { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$", ErrorMessage = "Invalid email")]
        [Display(Name = "Office email")]
        public string Email { get; set; }
        
        [Required]
        public Dept Department { get; set; }
    }
}
