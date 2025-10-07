using EmployeesService.DTOs;
using LeaveRequestService.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Shared.DTOs;

namespace LeaveRequestService.Services
{
    public class LeaveRequestsService : ILeaveRequestService
    {
        private readonly ILeaveRequestRepository _LeaveRequestService;

        public LeaveRequestsService(ILeaveRequestRepository LeaveRequestService)
        {
            _LeaveRequestService = LeaveRequestService;
        }

        public async Task<IEnumerable<LeaveRequestsDto>> GetAll()
        {
            return await _LeaveRequestService.GetAll().ToListAsync();
        }
    }
}
