using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeesService.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; } = null!;
        [Required]

        public string LastName { get; set; } = null!;
        [Required]

        public string Email { get; set; } = null!;
        public string? PhoneNumber { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public DateOnly? HireDate { get; set; }
        public decimal? Salary { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }

        [Required]
        public string Gender { get; set; } =  null!;

        [ForeignKey("Manager")]
        public int? ManagerId { get; set; }
        public virtual Employee? Manager { get; set; }

        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        public virtual Department? Department { get; set; }

        [ForeignKey("Position")]
        public int PositionId { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set ; }


    }
}
