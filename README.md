# 🏢 HRMS Microservices — ASP.NET Core

A modular **Human Resource Management System (HRMS)** built using **ASP.NET Core Microservices Architecture**.  
This project demonstrates a clean, scalable backend structure with multiple APIs communicating through an **API Gateway**.

Each commit represents a meaningful step in development — showing my growth and learning in microservices, clean architecture, and .NET backend design.

---

## 🚀 Overview

This project is a **microservices-based HR System** designed to handle core HR operations such as employee management, leave requests, and attendance tracking.

The system is built using:
- **ASP.NET Core Web API**
- **Entity Framework Core (Code-First)**
- **API Gateway**
- **SQL Server**
- **Clean Architecture principles**

---

## 🧩 Microservices

| Service | Description |
|----------|--------------|
| **API Gateway** | The central entry point that routes requests to the correct service and handles inter-service communication. |
| **Employees Service** | Manages employee records, departments, and positions. |
| **Leave Requests Service** | Handles employee leave requests, approvals, and validation. |


---

### 🗂️ Each microservice includes:
- **Controllers** — API endpoints
- **Services** — Business logic
- **Repositories** — Data access layer
- **DTOs / Models** — Data Transfer Objects
- **Migrations** — EF Core migrations and database schema

---

## ⚙️ Tech Stack

- **.NET 8 / ASP.NET Core Web API**
- **Entity Framework Core**
- **SQL Server**
- **Ocelot / YARP** (for API Gateway)
- **AutoMapper**
- **Swagger / OpenAPI**
- **Docker (planned)**

---

## 🧠 Learning Focus

This repository serves as a **learning and portfolio project**.  
Each commit documents a step in the learning journey:

- ✅ Setting up microservices in .NET  
- ✅ Configuring EF Core with separate databases  
- ✅ Implementing API Gateway routing  
- ✅ Handling inter-service communication (HTTP Clients)  
- ✅ Designing clean DTOs and responses  
- ✅ Error handling and global exception middleware  
- ✅ Logging and configuration management  

---

## 🧭 API Gateway Flow

```plaintext
Client → API Gateway → Employees Microservice → Employees Database
                     → Leave Requests Microservice → Leave Requests Database
