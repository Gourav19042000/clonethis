using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication12.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Required]
        public string Name { get; set; }

        [Display(Name = "Department")]

        public virtual int DepartmentId { get; set; }

        // [ForeignKey("DepartmentId")]
        // public virtual Department? Departments { get; set; }

    }
}
