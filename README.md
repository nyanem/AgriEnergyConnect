# Agri-Energy Connect

## 📌 Project Overview
Agri-Energy Connect is a web-based prototype built in C# .NET 8 using MVC architecture, Entity Framework Core, and Razor Pages.
It allows Employees to manage farmers and products, and Farmers to log in and manage their own products

## Requirements
- Windows 10/11
- Visual Studio 2022 with .NET 8 SDK
- SQLite (included in project)

## Setup
1. Clone the repository
2. Open AgriEnergyConnect.sln in Visual Studio
3. Press `Ctrl+F5` to run the application

The SQLite database `AgriEnergyConnect.db` is pre-populated.

## Default Logins
- Employee: employee@agrienergy.com / Demo@123
- Farmer: farmer@agrienergy.com / Demo@123

## Project Notes
- MVC architecture with Razor Pages
- Entity Framework Core (SQLite)
- Database and migrations included
- Pre-seeded data for demo purposes

## Project Structure
AgriEnergyConnect/
│── AgriEnergyConnect.sln
│── README.md
│── AgriEnergyConnect.db        <-- Pre-populated SQLite database
│── AgriEnergyConnect/
│   ├── Controllers/
│   ├── Models/
│   ├── Views/
│   ├── Areas/Identity/Pages/Account/  <-- Login & Register pages
│   ├── wwwroot/
│   ├── appsettings.json
│   └── Program.cs


## Roles
- Employee: Can manage farmers and products
- Farmer: Can log in and manage own products (future)
