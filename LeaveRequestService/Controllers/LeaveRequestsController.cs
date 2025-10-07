using LeaveRequestService.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared.DTOs;

namespace LeaveRequestService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaveRequestsController : ControllerBase
    {
        private readonly ILeaveRequestService _LeaveRequestService;

        public LeaveRequestsController(ILeaveRequestService LeaveRequestService)
        {
            _LeaveRequestService = LeaveRequestService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
           var Requests = await _LeaveRequestService.GetAll();
            return Ok(Requests);
        }

    }
}
