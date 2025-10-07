using LeaveRequestService.Data;
using LeaveRequestService.Models;
using LeaveRequestService.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Shared.DTOs;

namespace LeaveRequestService.Repositories
{
    public class LeaveRequestRepository : ILeaveRequestRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public LeaveRequestRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<LeaveRequestsDto> GetAll()
             => _dbContext.LeaveRequests.Select(E => new LeaveRequestsDto
             {
                 CreatedAt = E.CreatedAt,
                 DateEnd = E.DateEnd,
                 DateStart = E.DateStart,
                 EmployeeId = E.EmployeeId,
                 Id = E.Id,
                 LeaveTypeId = E.LeaveTypeId,
                 LeaveTypeName = E.LeaveType.Name,
                 RequestStatusId = E.RequestStatusId,
                 RequestStatusName = E.RequestStatus.Name

             }).AsNoTracking();

    }
}
