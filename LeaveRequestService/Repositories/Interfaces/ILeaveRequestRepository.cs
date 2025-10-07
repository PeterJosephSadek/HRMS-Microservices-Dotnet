using Shared.DTOs;

namespace LeaveRequestService.Repositories.Interfaces
{
    public interface ILeaveRequestRepository
    {
        public IQueryable<LeaveRequestsDto> GetAll();
    }
}
