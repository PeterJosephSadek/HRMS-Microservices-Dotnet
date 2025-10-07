using LeaveRequestService.Models;
using Microsoft.EntityFrameworkCore;

namespace LeaveRequestService.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<LeaveRequest> LeaveRequests { get; set; }
        public DbSet<LeaveType> LeaveTypes { get; set; }
        public DbSet<RequestStatus> RequestStatuses { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // LeaveType Seed
            modelBuilder.Entity<LeaveType>().HasData(
                new LeaveType { Id = 1, Name = "Annual Leave", Description = "Paid time off for vacation or rest", CreatedAt = DateTime.Now },
                new LeaveType { Id = 2, Name = "Sick Leave", Description = "Leave for illness or medical appointments", CreatedAt = DateTime.Now },
                new LeaveType { Id = 3, Name = "Casual Leave", Description = "Short-term leave for personal reasons", CreatedAt = DateTime.Now },
                new LeaveType { Id = 4, Name = "Maternity Leave", Description = "Leave for maternity-related reasons", CreatedAt = DateTime.Now },
                new LeaveType { Id = 5, Name = "Unpaid Leave", Description = "Leave without pay", CreatedAt = DateTime.Now }
            );

            // RequestStatus Seed
            modelBuilder.Entity<RequestStatus>().HasData(
                new RequestStatus { Id = 1, Name = "Pending", Description = "Awaiting review or approval", CreatedAt = DateTime.Now },
                new RequestStatus { Id = 2, Name = "Approved", Description = "Request has been approved", CreatedAt = DateTime.Now },
                new RequestStatus { Id = 3, Name = "Rejected", Description = "Request has been rejected", CreatedAt = DateTime.Now },
                new RequestStatus { Id = 4, Name = "Cancelled", Description = "Request was cancelled by employee", CreatedAt = DateTime.Now }
            );

            // LeaveRequest Seed
            modelBuilder.Entity<LeaveRequest>().HasData(
                new LeaveRequest
                {
                    Id = 1,
                    EmployeeId = 1,
                    LeaveTypeId = 1,
                    RequestStatusId = 1,
                    DateStart = new DateOnly(2025, 10, 10),
                    DateEnd = new DateOnly(2025, 10, 15),
                    Reason = "Family vacation",
                    CreatedAt = DateTime.Now
                },
                new LeaveRequest
                {
                    Id = 2,
                    EmployeeId = 2,
                    LeaveTypeId = 2,
                    RequestStatusId = 2,
                    DateStart = new DateOnly(2025, 9, 25),
                    DateEnd = new DateOnly(2025, 9, 28),
                    Reason = "Flu recovery",
                    CreatedAt = DateTime.Now,
                    ApprovedAt = DateTime.Now
                },
                new LeaveRequest
                {
                    Id = 3,
                    EmployeeId = 3,
                    LeaveTypeId = 5,
                    RequestStatusId = 3,
                    DateStart = new DateOnly(2025, 10, 20),
                    DateEnd = new DateOnly(2025, 10, 21),
                    Reason = "Personal reason",
                    CreatedAt = DateTime.Now
                }
            );
        }


    }
}
