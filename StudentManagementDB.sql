CREATE DATABASE StudentManagementDB;
GO

USE StudentManagementDB;
GO

CREATE TABLE Students
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100) NOT NULL,
    Age INT NOT NULL,
    Course NVARCHAR(100) NOT NULL,
    CreatedDate DATETIME DEFAULT GETDATE()
);
GO

INSERT INTO Students(Name, Email, Age, Course)
VALUES
('Rahul Sharma','rahul@gmail.com',22,'Computer Science'),
('Priya Singh','priya@gmail.com',21,'Information Technology');
GO