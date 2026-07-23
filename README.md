# Student Management System - ASP.NET Core Web API

## Overview

This project is a **Student Management System** developed using **ASP.NET Core Web API**. It provides secure REST APIs to perform CRUD operations on student records using **JWT Authentication**. The project follows a **Layered Architecture** with Repository and Service patterns for clean and maintainable code.

## Features

* JWT Authentication
* Get All Students
* Add Student
* Update Student
* Delete Student
* SQL Server Database
* Global Exception Handling Middleware
* Built-in Logging / Serilog
* Swagger API Documentation
* Layered Architecture (Controller, Service, Repository)

## Technologies Used

* ASP.NET Core Web API
* C#
* Entity Framework Core
* SQL Server
* JWT Authentication
* Swagger (Swashbuckle)
* Serilog / Built-in Logging

## Project Structure

```
StudentManagementAPI
│
├── Controllers
├── Services
├── Repositories
├── Models
├── DTOs
├── Data
├── Middleware
├── appsettings.json
├── Program.cs
└── README.md
```

## Database

Create a SQL Server database and execute the following table script:

```sql
CREATE TABLE Students
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100) NOT NULL,
    Age INT NOT NULL,
    Course NVARCHAR(100) NOT NULL,
    CreatedDate DATETIME DEFAULT GETDATE()
);
```

## Required NuGet Packages

Install the following packages:

* Microsoft.EntityFrameworkCore.SqlServer
* Microsoft.EntityFrameworkCore.Tools
* Microsoft.AspNetCore.Authentication.JwtBearer
* Swashbuckle.AspNetCore
* Serilog.AspNetCore

## Configuration

Update the SQL Server connection string in **appsettings.json**.

Example:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER;Database=StudentDB;Trusted_Connection=True;TrustServerCertificate=True;"
}
```

Also configure JWT settings:

```json
"Jwt": {
  "Key": "YourSecretKey123456789",
  "Issuer": "StudentAPI",
  "Audience": "StudentAPI"
}
```

## How to Run

1. Clone the repository.
2. Open the project in Visual Studio 2022.
3. Restore NuGet packages.
4. Update the SQL Server connection string.
5. Run the application.
6. Open Swagger.

## Authentication

Call the Login API first to generate a JWT token.

**Sample Credentials**

* Username: `admin`
* Password: `admin123`

Copy the generated token.

Click **Authorize** in Swagger and paste:

```
Bearer YOUR_TOKEN
```

## API Endpoints

### Authentication

**POST**

```
/api/auth/login
```

### Students

**GET**

```
/api/student
```

Returns all students.

---

**POST**

```
/api/student
```

Adds a new student.

---

**PUT**

```
/api/student/{id}
```

Updates an existing student.

---

**DELETE**

```
/api/student/{id}
```

Deletes a student.

## Sample Student JSON

```json
{
  "name": "Renu Deshmukh",
  "email": "renu@example.com",
  "age": 24,
  "course": "ASP.NET Core"
}
```

## Project Highlights

* Secure APIs using JWT Authentication
* Clean Layered Architecture
* SQL Server integration using Entity Framework Core
* Global Exception Handling Middleware
* Logging support
* Interactive Swagger Documentation

## Author

**Renu Deshmukh**
