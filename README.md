# Student Management System - ASP.NET Core Web API

## Overview

Student Management System is an ASP.NET Core Web API project developed to manage student records using RESTful APIs.

The project follows a layered architecture with Controller, Service, and Repository layers. It includes JWT Authentication, SQL Server database integration, Entity Framework Core, Swagger API documentation, Global Exception Handling Middleware, and Serilog logging.

---

## Features

- Student CRUD Operations
- JWT Authentication
- Secure API Endpoints
- Layered Architecture
- Repository Pattern
- Entity Framework Core
- SQL Server Database
- Swagger API Documentation
- Global Exception Handling Middleware
- Serilog Logging
- Input Validation

---

## Technology Stack

- ASP.NET Core Web API (.NET 10)
- C#
- Entity Framework Core
- SQL Server
- JWT Authentication
- Swagger / OpenAPI
- Serilog
- Visual Studio 2022

---

## Project Architecture

```
StudentManagementSystem

│
├── Controllers
│   ├── AuthController.cs
│   └── StudentsController.cs
│
├── Services
│   ├── IStudentService.cs
│   └── StudentService.cs
│
├── Repositories
│   ├── IStudentRepository.cs
│   └── StudentRepository.cs
│
├── Models
│   ├── Student.cs
│   ├── LoginRequest.cs
│   └── LoginResponse.cs
│
├── Data
│   └── AppDbContext.cs
│
├── Middleware
│   └── ExceptionMiddleware.cs
│
├── Database
│   └── StudentManagementDB.sql
│
├── Program.cs
├── appsettings.json
└── README.md
```

---

# Database Setup

## Option 1: SQL Script

1. Open SQL Server Management Studio (SSMS)
2. Open:

```
Database/StudentManagementDB.sql
```

3. Execute the script.

It will create:

Database:

```
StudentManagementDB
```

Table:

```
Students
```

---

## Student Table Structure

| Column | Data Type |
|---|---|
| Id | int |
| Name | nvarchar(100) |
| Email | nvarchar(100) |
| Age | int |
| Course | nvarchar(100) |
| CreatedDate | datetime |

---

# Configure Connection String

Update `appsettings.json` according to your SQL Server instance.

Example:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=StudentManagementDB;Trusted_Connection=True;TrustServerCertificate=True"
}
```

---

# Entity Framework Migration (Alternative)

Run the following commands in Package Manager Console:

```
Add-Migration InitialCreate
```

```
Update-Database
```

---

# JWT Authentication

The API uses JWT Authentication to secure student endpoints.

## Login API

```
POST /api/auth/login
```

Request:

```json
{
  "username": "admin",
  "password": "admin123"
}
```

Response:

```json
{
  "token": "JWT_TOKEN"
}
```

Use this token in Swagger:

```
Authorize → Bearer Token
```

Format:

```
Bearer YOUR_TOKEN
```

---

# API Endpoints

## Authentication

| Method | Endpoint |
|---|---|
| POST | /api/auth/login |

---

## Student APIs

| Method | Endpoint | Description |
|---|---|---|
| GET | /api/students | Get all students |
| GET | /api/students/{id} | Get student by id |
| POST | /api/students | Add new student |
| PUT | /api/students/{id} | Update student |
| DELETE | /api/students/{id} | Delete student |

---

# Swagger Documentation

Run the project and open:

```
https://localhost:<port>/swagger
```

Swagger provides API testing and JWT authorization support.

---

# Logging

Serilog is configured for application logging.

Logs are stored in:

```
Logs/log-.txt
```

---

# Exception Handling

Global Exception Middleware handles unexpected errors and returns standard error responses.

Example:

```json
{
  "success": false,
  "message": "Internal Server Error"
}
```

---

# How to Run the Project

## Step 1

Clone repository:

```
git clone <repository-url>
```

## Step 2

Open solution file:

```
StudentManagementSystem.sln
```

## Step 3

Restore NuGet packages.

## Step 4

Configure SQL Server connection string.

## Step 5

Run application:

```
Ctrl + F5
```

---

# Security

- JWT Based Authentication
- Protected Student APIs
- Input Validation
- Exception Handling
- Secure Database Access

---

# Future Enhancements

- Unit Testing
- Docker Support
- Role Based Authorization
- Frontend Integration (Angular/React)

---

# Author

**Renu Deshmukh**

Software Developer  
ASP.NET Core | C# | SQL Server | Python
