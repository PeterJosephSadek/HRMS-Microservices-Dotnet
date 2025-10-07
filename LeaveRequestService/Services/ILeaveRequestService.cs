using Shared.DTOs;

namespace LeaveRequestService.Services
{
    public interface ILeaveRequestService
    {
        public Task<IEnumerable<LeaveRequestsDto>> GetAll();
    }
}
