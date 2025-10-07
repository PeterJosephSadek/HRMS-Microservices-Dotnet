using EmployeesService.DTOs;
using EmployeesService.Models;
using EmployeesService.Repositories;
using EmployeesService.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Shared.DTOs;

namespace EmployeesService.Services.Interfaces
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public Task<int> AddEmployee(CreateEmployeeDto dto)
        {
            return _employeeRepository.Add(dto);
        }

        public async Task<IEnumerable<EmployeesDto>> GetAll()
        {
            return await _employeeRepository.GetAll().ToListAsync();
        }

        public Task<EmployeeDetailsDto> GetById(int EmployeeId)
        {
            return _employeeRepository.GetById(EmployeeId);
        }

        public async Task<IEnumerable<EmployeesNamesDto>> GetEmployeesByIds(List<int> employeeIds)
        {
            return await _employeeRepository.GetEmployeesByIds(employeeIds).ToListAsync();
        }
    }
}
