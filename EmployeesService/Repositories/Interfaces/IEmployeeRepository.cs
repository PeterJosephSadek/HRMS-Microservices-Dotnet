using EmployeesService.DTOs;
using EmployeesService.Models;
using Shared.DTOs;

namespace EmployeesService.Repositories.Interfaces
{
    public interface IEmployeeRepository
    {
        public IQueryable<EmployeesDto> GetAll();
        public Task<EmployeeDetailsDto> GetById(int EmployeeId);
        public IQueryable<EmployeesNamesDto> GetEmployeesByIds(List<int> employeeIds);

        public Task<int> Add(CreateEmployeeDto dto);


    }
}
