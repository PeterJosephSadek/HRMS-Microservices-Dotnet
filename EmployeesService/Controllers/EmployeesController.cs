using EmployeesService.DTOs;
using EmployeesService.Models;
using EmployeesService.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmployeesService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var employees = await _employeeService.GetAll();
            return Ok(employees);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateEmployeeDto dto)
        {
            var respond = await _employeeService.AddEmployee(dto);
            if (respond == 1)
            {
                return Ok();
            }
            return BadRequest("Something went wrong");
        }

        [HttpGet("{EmployeeId}")]
        public async Task<IActionResult> Details(int EmployeeId)
        {
            var employees = await _employeeService.GetById(EmployeeId);
            if (employees != null)
                 return Ok(employees);
            else 
                return NotFound();
        }

        [HttpPost("by-ids")]
        public async Task<IActionResult> GetEmployeesByIds([FromBody] List<int> employeeIds)
        {
            if (employeeIds == null || !employeeIds.Any())
                return BadRequest("No employee IDs provided.");

            var employees = await _employeeService.GetEmployeesByIds(employeeIds);

            return Ok(employees);
        }
    }
}
