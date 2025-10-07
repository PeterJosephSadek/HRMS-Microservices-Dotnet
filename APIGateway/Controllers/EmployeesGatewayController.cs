using EmployeesService.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;

namespace APIGateway.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesGatewayController : ControllerBase
    {
        private readonly string EmployeesAPIUrl = "https://localhost:7122/api/employees";
        private readonly HttpClient _httpClient;

        public EmployeesGatewayController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {

            var response = await _httpClient.GetAsync(EmployeesAPIUrl);

            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadFromJsonAsync<List<EmployeesDto>>();
                return Ok(data);
            }
            return NotFound();

        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateEmployeeDto dto)
        {
            var response = await _httpClient.PostAsJsonAsync(EmployeesAPIUrl, dto);

            if (response.IsSuccessStatusCode)
            {
                return Ok("Employee created successfully");
            }

            return StatusCode((int)response.StatusCode, await response.Content.ReadAsStringAsync());
        }

        [HttpGet("{EmployeeId}")]
        public async Task<IActionResult> Details(int EmployeeId)
        {

            // Example: https://localhost:7122/api/Employees/5
            var response = await _httpClient.GetAsync($"{EmployeesAPIUrl}/{EmployeeId}");

            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadFromJsonAsync<EmployeeDetailsDto>();
                return Ok(data);
            }
            return NotFound();

        }
    }
}
