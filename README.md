# Student Management System - ASP.NET Core Web API

## Overview

This project is a Student Management System developed using ASP.NET Core Web API following a Layered Architecture. It provides secure REST APIs to manage student records with JWT Authentication, Entity Framework Core, SQL Server, Swagger documentation, Global Exception Handling, and Serilog logging.

---

## Features

- JWT Authentication
- CRUD Operations
- Layered Architecture
- Repository Pattern
- Entity Framework Core
- SQL Server
- Global Exception Handling Middleware
- Serilog Logging
- Swagger Documentation
- Dependency Injection
- Clean Code Structure

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

## Project Structure

```
StudentManagementSystem
│
├── Controllers
├── Services
├── Repositories
├── Models
├── Data
├── Middleware
├── Helpers
├── appsettings.json
├── Program.cs
└── README.md
```

---

## Database

Database Name

```
StudentManagementDB
```

Student Table

| Column | Type |
|---------|------|
| Id | int |
| Name | nvarchar |
| Email | nvarchar |
| Age | int |
| Course | nvarchar |
| CreatedDate | datetime |

---

## API Endpoints

### Authentication

| Method | Endpoint |
|--------|----------|
| POST | /api/auth/login |

Default Credentials

```
Username : admin
Password : admin123
```

---

### Student APIs

| Method | Endpoint |
|--------|----------|
| GET | /api/students |
| GET | /api/students/{id} |
| POST | /api/students |
| PUT | /api/students/{id} |
| DELETE | /api/students/{id} |

---

## Setup Instructions

### Clone Repository

```bash
git clone https://github.com/yourusername/StudentManagementSystem-WebAPI.git
```

### Open Project

Open the solution in Visual Studio 2022.

### Configure Database

Update the connection string inside **appsettings.json**

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER;Database=StudentManagementDB;Trusted_Connection=True;TrustServerCertificate=True;"
}
```

---

### Apply Migration

```powershell
Add-Migration InitialCreate

Update-Database
```

---

### Run Project

Press

```
F5
```

or

```
Ctrl + F5
```

---

## Swagger

```
https://localhost:5001/swagger
```

Use the Login API to generate the JWT token.

Click **Authorize** and enter:

```
Bearer YOUR_TOKEN
```

Now all protected APIs can be accessed.

---

## Logging

Serilog is configured to generate logs.

```
Logs/
    log-.txt
```

---

## Error Handling

Global Exception Middleware returns consistent JSON responses for unhandled exceptions.

Example

```json
{
  "success": false,
  "message": "Internal Server Error"
}
```

---

## Security

- JWT Authentication
- Secure API Endpoints
- Input Validation
- Exception Handling
- Dependency Injection

---

## Future Enhancements

- Unit Testing
- Docker Support
- Role-Based Authentication
- Angular/React Frontend

---

## Author

**Renu Deshmukh**

Software Developer | ASP.NET Core | C# | SQL Server | Python
