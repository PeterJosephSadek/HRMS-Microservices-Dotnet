using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveRequestService.Models
{
    public class LeaveRequest
    {
        public int Id { get; set; }

        [Required]
        public DateOnly DateStart { get; set; }
        [Required]
        public DateOnly DateEnd { get; set; }
        public string? Reason { get; set; }

        public DateTime? CreatedAt { get; set; }
        public DateTime? ApprovedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        [Required]
        public int EmployeeId { get; set; }


        [ForeignKey("LeaveType")]
        [Required]
        public int? LeaveTypeId { get; set; }
        public virtual LeaveType? LeaveType { get; set; }


        [ForeignKey("RequestStatus")]
        public int? RequestStatusId { get; set; }
        public virtual RequestStatus? RequestStatus { get; set; }


    }
}
