using System.ComponentModel.DataAnnotations;

namespace EmployeesService.Models
{
    public class Department
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public bool IsActive { get; set; } = true;

        public virtual ICollection<Employee>? Employees { get; set; }

    }
}
