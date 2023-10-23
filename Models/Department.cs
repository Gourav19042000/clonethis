using System.ComponentModel.DataAnnotations;

namespace WebApplication12.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        [Required]
        public string? DepartmentName { get; set; }
    }
}
