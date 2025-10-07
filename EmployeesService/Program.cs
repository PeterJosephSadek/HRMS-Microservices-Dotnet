using EmployeesService.Data;
using EmployeesService.Repositories.Interfaces;
using EmployeesService.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using EmployeesService.Services.Interfaces;

namespace EmployeesService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            // Add DbContext and connect to SQL Server
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseLazyLoadingProxies().UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


            // Register Services for DI
            builder.Services.AddScoped<IEmployeeService, EmployeeService>();

            // Register repositories for DI
            builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();


            // Add services to the container.
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
