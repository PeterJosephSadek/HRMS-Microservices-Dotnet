using EmployeesService.DTOs;
using EmployeesService.Models;
using Shared.DTOs;

namespace EmployeesService.Services.Interfaces
{
    public interface IEmployeeService
    {
        public Task<IEnumerable<EmployeesDto>> GetAll();
        public Task<EmployeeDetailsDto> GetById(int EmployeeId);
        public Task<IEnumerable<EmployeesNamesDto>> GetEmployeesByIds(List<int> employeeIds);

        public Task<int> AddEmployee(CreateEmployeeDto dto);

    }
}
