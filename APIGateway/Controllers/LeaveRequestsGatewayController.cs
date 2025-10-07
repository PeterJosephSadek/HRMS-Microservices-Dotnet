using APIGateway.Dtos;
using EmployeesService.DTOs;
using Microsoft.AspNetCore.Mvc;
using Shared.DTOs;

namespace APIGateway.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaveRequestsGatewayController : ControllerBase
    {
        private readonly HttpClient _employeesClient;
        private readonly HttpClient _leaveRequestsClient;

        public LeaveRequestsGatewayController(IHttpClientFactory httpClientFactory)
        {
            _employeesClient = httpClientFactory.CreateClient("EmployeesAPI");
            _leaveRequestsClient = httpClientFactory.CreateClient("LeaveRequestsAPI");
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var leaveRequestsResponse = await _leaveRequestsClient.GetAsync("");

            if (!leaveRequestsResponse.IsSuccessStatusCode)
                return NotFound();

            var leaveRequests = await leaveRequestsResponse.Content
                .ReadFromJsonAsync<IEnumerable<Shared.DTOs.LeaveRequestsDto>>();

            if (leaveRequests == null || !leaveRequests.Any())
                return Ok(Enumerable.Empty<APIGateway.Dtos.LeaveRequestsDto>());

            // Get distinct Employee IDs
            var employeeIds = leaveRequests.Select(x => x.EmployeeId).Distinct().ToList();

            // Request only those employees
            var employeesResponse = await _employeesClient.PostAsJsonAsync("by-ids", employeeIds);
            var employees = await employeesResponse.Content
                .ReadFromJsonAsync<IEnumerable<EmployeesNamesDto>>();

            // Combine data
            var result = leaveRequests.Select(lr => new APIGateway.Dtos.LeaveRequestsDto
            {
                Id = lr.Id,
                EmployeeId = lr.EmployeeId,
                EmployeeName = employees?.FirstOrDefault(e => e.EmployeeId == lr.EmployeeId)?.EmployeeName ?? "Unknown",
                CreatedAt = lr.CreatedAt,
                LeaveTypeId = lr.LeaveTypeId,
                RequestStatusId = lr.RequestStatusId,
                LeaveTypeName = lr.LeaveTypeName,
                RequestStatusName = lr.RequestStatusName,
                DateStart = lr.DateStart,
                DateEnd = lr.DateEnd
            });

            return Ok(result);
        }
    }
}
