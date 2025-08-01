# Agri-Energy Connect

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

## Roles
- Employee: Can manage farmers and products
- Farmer: Can log in and manage own products (future)
