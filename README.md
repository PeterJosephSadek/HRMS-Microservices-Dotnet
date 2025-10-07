# HR System Microservices

A modular HR management system built with .NET microservices architecture, demonstrating clean architecture principles, database isolation, and performance-optimized service communication.

## 🏗️ Architecture Overview

This project implements a **clean architecture** approach with clear separation of concerns across multiple microservices:

- **APIGateway** - Entry point for all client requests, routing to appropriate microservices
- **EmployeesService** - Manages employee data, profiles, and employee-related operations
- **LeaveRequestService** - Handles leave requests, approvals, and leave balance management
- **Shared** - Common DTOs, models, and utilities shared across services

### Clean Architecture Implementation

Each microservice follows **clean architecture** principles with distinct layers:

- **Controllers** - API endpoints and request handling
- **Services** - Business logic and orchestration layer
- **Repositories** - Data access abstraction layer
- **Models** - Domain entities and business models
- **DTOs** - Data transfer objects for API contracts
- **APIClients** - HTTP clients for inter-service communication

This structure ensures:
- ✅ **Scalability** - Easy to add new features and services
- ✅ **Maintainability** - Clear separation of concerns
- ✅ **Testability** - Each layer can be tested independently
- ✅ **Flexibility** - Swap implementations without affecting business logic

## 🗄️ Database Architecture

### Database-Per-Service Pattern

Each microservice maintains **its own isolated database**:

- **EmployeesService** → `EmployeesDB`
- **LeaveRequestService** → `LeaveRequestsDB`

#### Why Database-Per-Service?

1. **Service Independence** - Services can be deployed, scaled, and updated independently without database coupling
2. **Technology Flexibility** - Each service can choose the optimal database technology for its needs
3. **Fault Isolation** - Database failures are contained to individual services
4. **Scalability** - Databases can be scaled independently based on service-specific load patterns
5. **Clear Boundaries** - Enforces bounded contexts and prevents tight coupling between services

## ⚡ Performance Optimizations

### Optimized Database Access

To minimize database round-trips and improve response times:

- **Batch Queries** - Commonly used related data is fetched in a single database trip
- **Query Optimization** - Related entities are loaded efficiently to avoid N+1 query problems
- **Strategic Eager Loading** - Frequently accessed relationships are loaded proactively

### Inter-Service Communication

- **Efficient API Calls** - Services communicate via HTTP using `HttpClient` with optimized payloads
- **Data Transfer Optimization** - DTOs are designed to minimize over-fetching and reduce network overhead

## 🚀 Technology Stack

- **.NET 8** (or your version) - Framework
- **ASP.NET Core Web API** - RESTful services
- **Entity Framework Core** - ORM and database access
- **HTTP Client** - Inter-service communication

## 📁 Project Structure

**APIGateway** - API Gateway routing requests to microservices
- `Controllers/` - Gateway endpoints
- `APIClients/` - HTTP clients for service-to-service communication
- `Dtos/` - Data transfer objects

**EmployeesService** - Employee management microservice
- `Controllers/` - Employee API endpoints
- `Services/` - Business logic layer
- `Repositories/` - Data access layer
- `Models/` - Domain entities
- `Data/` - DbContext and configurations
- `Migrations/` - EF Core database migrations

**LeaveRequestService** - Leave request management microservice
- `Controllers/` - Leave request API endpoints
- `Services/` - Business logic layer
- `Repositories/` - Data access layer
- `Models/` - Domain entities
- `Data/` - DbContext and configurations
- `Migrations/` - EF Core database migrations

**Shared** - Common libraries and DTOs
- `DTOs/` - Shared data transfer objects across services

## 🎯 Learning Objectives

This project is built as a **learning showcase** to demonstrate:

- Microservices architecture design and implementation
- Clean architecture with repository and service patterns
- Database-per-service pattern and service isolation
- Performance optimization through query batching
- Inter-service communication patterns
- Entity Framework Core with Code-First migrations
- RESTful API design and best practices

## 🔄 Project Evolution

This repository is actively developed with **incremental commits**, where each commit introduces a new feature or improvement. Follow the commit history to see the project's evolution and understand the development process.

## 📝 Future Enhancements

- [ ] Authentication & Authorization (JWT)
- [ ] Frontend implementation (Angular)
- [ ] Containerization with Docker
- [ ] Logging and monitoring (Serilog, Application Insights)
- [ ] API documentation (Swagger)

## 🤝 Contributing

This is a personal learning project, but suggestions and feedback are welcome! Feel free to open issues or submit pull requests.
