using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EmployeesService.DTOs
{
    public class EmployeesDto
    {

        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public decimal? Salary { get; set; }
        public string Gender { get; set; } = null!;
        public int? ManagerId { get; set; }
        public string ManagerName { get; set; } = null!;
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; } = null!;
        public int PositionId { get; set; }


    }
}
