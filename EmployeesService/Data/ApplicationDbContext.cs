using EmployeesService.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace EmployeesService.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // --- SEED DEPARTMENTS ---
            modelBuilder.Entity<Department>().HasData(
                new Department
                {
                    Id = 1,
                    Name = "Human Resources",
                    Description = "Handles employee management, payroll, and company culture.",
                    CreatedAt = DateTime.Now,
                    IsActive = true
                },
                new Department
                {
                    Id = 2,
                    Name = "IT Department",
                    Description = "Manages infrastructure, applications, and software development.",
                    CreatedAt = DateTime.Now,
                    IsActive = true
                },
                new Department
                {
                    Id = 3,
                    Name = "Finance",
                    Description = "Responsible for budgeting, financial planning, and reporting.",
                    CreatedAt = DateTime.Now,
                    IsActive = true
                }
            );

            // --- SEED EMPLOYEES ---
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1,
                    FirstName = "John",
                    LastName = "Doe",
                    Email = "john.doe@company.com",
                    PhoneNumber = "01000000000",
                    DateOfBirth = new DateOnly(1990, 5, 20),
                    HireDate = new DateOnly(2020, 1, 15),
                    Salary = 8000,
                    Address = "123 Main St",
                    City = "Cairo",
                    Country = "Egypt",
                    Gender = "Male",
                    DepartmentId = 2,
                    PositionId = 1,
                    CreatedAt = DateTime.Now
                },
                new Employee
                {
                    Id = 2,
                    FirstName = "Sara",
                    LastName = "Ahmed",
                    Email = "sara.ahmed@company.com",
                    PhoneNumber = "01011111111",
                    DateOfBirth = new DateOnly(1994, 7, 10),
                    HireDate = new DateOnly(2021, 6, 1),
                    Salary = 7500,
                    Address = "456 Nile St",
                    City = "Alexandria",
                    Country = "Egypt",
                    Gender = "Female",
                    DepartmentId = 1,
                    PositionId = 2,
                    CreatedAt = DateTime.Now,
                    ManagerId = 1
                }
            );
        }
    }
}
