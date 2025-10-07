using System.ComponentModel.DataAnnotations;

namespace LeaveRequestService.Models
{
    public class RequestStatus
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }

        public string? Description { get; set; }

        public DateTime? CreatedAt { get; set; }

        public virtual ICollection<LeaveRequest>? LeaveRequests { get; set; }
    }
}
