namespace APIGateway.Dtos
{
    public class LeaveRequestsDto
    {
        public int Id { get; set; }
        public DateOnly DateStart { get; set; }
        public DateOnly DateEnd { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int EmployeeId { get; set; }
        public string? EmployeeName { get; set; }
        public int? LeaveTypeId { get; set; }
        public string? LeaveTypeName { get; set; }
        public int? RequestStatusId { get; set; }
        public string? RequestStatusName { get; set; }


    }
}
