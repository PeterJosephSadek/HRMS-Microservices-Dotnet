using EmployeesService.Data;
using EmployeesService.DTOs;
using EmployeesService.Models;
using EmployeesService.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Shared.DTOs;

namespace EmployeesService.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public EmployeeRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> Add(CreateEmployeeDto dto)
        {
            var Employee = new Employee
            {
                Address = dto.Address,
                City = dto.City,
                Country = dto.Country,
                CreatedAt = DateTime.Now,
                DateOfBirth = dto.DateOfBirth,
                DepartmentId = dto.DepartmentId,
                Email = dto.Email,
                FirstName = dto.FirstName,
                Gender = dto.Gender,
                HireDate = dto.HireDate,
                LastName = dto.LastName,
                ManagerId = dto.ManagerId,
                PhoneNumber = dto.PhoneNumber,
                PositionId = dto.PositionId,
                Salary = dto.Salary
            };
           await _dbContext.Employees.AddAsync(Employee);
          return await  _dbContext.SaveChangesAsync();
        }

        public IQueryable<EmployeesDto> GetAll()
            => _dbContext.Employees.Select(E => new EmployeesDto
            {
                DepartmentId = E.DepartmentId,
                DepartmentName = E.Department.Name,
                FirstName = E.FirstName,
                LastName = E.LastName,
                Email = E.Email,
                Gender = E.Gender,
                Id = E.Id,
                ManagerId = E.ManagerId,
                ManagerName = E.Manager.FirstName +" "+ E.Manager.LastName,
                PositionId = E.PositionId,
                Salary = E.Salary,
            }).AsNoTracking();

        public async Task<EmployeeDetailsDto> GetById(int EmployeeId)
        {
            EmployeeDetailsDto? employee = await _dbContext.Employees.Where(e=>e.Id == EmployeeId).Select(e=> new EmployeeDetailsDto
            {
                Id = EmployeeId,
                Address = e.Address,
                City = e.City,
                Country = e.Country,
                CreatedAt = e.CreatedAt,
                DateOfBirth = e.DateOfBirth,
                DepartmentId=e.DepartmentId,
                DepartmentName = e.Department.Name,
                FirstName = e.FirstName,
                Email = e.Email,
                Gender = e.Gender,
                HireDate = e.HireDate,
                LastName= e.LastName,
                ManagerId=e.ManagerId,
                ManagerName = e.Manager.FirstName + " " + e.Manager.LastName,
                PhoneNumber = e.PhoneNumber,
                PositionId=e.PositionId,
                Salary = e.Salary,
                UpdatedAt = e.UpdatedAt,

            }).FirstOrDefaultAsync();
            return employee!;
        }

        public IQueryable<EmployeesNamesDto> GetEmployeesByIds(List<int> employeeIds)
        {
          return  _dbContext.Employees.Where(E => employeeIds.Contains(E.Id)).Select(E => new EmployeesNamesDto
            {
                EmployeeId = E.Id,
                EmployeeName = E.FirstName + " " + E.LastName,
            });

        }
    }
}
