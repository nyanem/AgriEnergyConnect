# AgriEnergyConnect

The **Agri-Energy Connect Platform** is a web-based system designed to connect farmers with energy and sustainability initiatives. Built using ASP.NET Core MVC and SQL Server, the platform allows employees to manage farmer records and products, and farmers to manage their own product data.

This application is a prototype developed as part of a software development module and demonstrates CRUD operations, role-based access control (under development), and future readiness for cloud deployment and performance scaling.

## 🚀 How to Set Up and Run the App

### 🔧 Prerequisites

- Visual Studio 2022 or newer
- .NET 9 SDK
- SQL Server + SQL Server Management Studio (SSMS)
- Git

## Set up the Database 
Open SSMS and connect to your local SQL Server.
Run the SQL script AgriEnergyConnectDB.sql to create the database with Farmers and Products tables.
Make sure your connection string in appsettings.json points to the right server:
"Server=localhost\\SQLEXPRESS;Database=AgriEnergyConnectDB;Trusted_Connection=True;TrustServerCertificate=True;"

## Run the App
Open the .sln file in Visual Studio
Press Ctrl + F5 to run without debugging
Navigate to:
/Farmers for the Employee interface (view and manage farmers)
/Products for product management
/Identity/Account/Login to access login functionality (under development)

## Improvements Made 
### Part 1: Planning & Architecture
- Applied feedback to improve report structure, tone, and layout.
- Added value-driven analysis of non-functional requirements (performance, scalability).
- Clarified the role of design patterns (MVC, Repository, Observer) and architecture (N-Tier, Microservices).
- Added citations and diagrams for improved presentation quality.
  
### Part 2: Prototype
- Rebuilt database using SQL Server (SSMS) for real-world simulation.
- Switched to database-first approach and scaffolded models using Entity Framework Core.
- Implemented scaffolded CRUD functionality for Farmers and Products.
- Fixed routing, controller registration, and data binding issues.
- Began integrating ASP.NET Identity and role-based access control.
- Added validation plans and UI design improvements for future phases.

## Technologies Used

ASP.NET Core MVC (.NET 9)
Entity Framework Core
SQL Server (SSMS)
Razor Views
Identity Framework (in progress)
Visual Studio 2022

## Known Issues / To-Do

Complete role-based login and farmer account creation
Add user-friendly Bootstrap UI
Implement product filtering by category/date for employee role
Add unit tests and user validation
