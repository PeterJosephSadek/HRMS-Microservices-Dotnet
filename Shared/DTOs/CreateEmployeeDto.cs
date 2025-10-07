using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EmployeesService.DTOs
{
    public class CreateEmployeeDto
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? PhoneNumber { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public DateOnly? HireDate { get; set; }
        public decimal? Salary { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public string Gender { get; set; } = null!;
        public int? ManagerId { get; set; }
        public int DepartmentId { get; set; }
        public int PositionId { get; set; }

    }
}
