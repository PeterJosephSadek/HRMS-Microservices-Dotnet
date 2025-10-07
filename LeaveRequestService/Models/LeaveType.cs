using System.ComponentModel.DataAnnotations;

namespace LeaveRequestService.Models
{
    public class LeaveType
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public DateTime? CreatedAt { get; set; }

        public virtual ICollection<LeaveRequest>? LeaveRequests { get; set; }

    }
}
