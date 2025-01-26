# SalesWebMvc

This repository contains a study project originally developed by Professor Nelio Alves as part of a .NET course. The goal of the project is to explore fundamental concepts of web development using the ASP.NET MVC framework.

## Updates and Improvements

The original project used older versions of technologies, but adjustments have been made to ensure compatibility with newer versions, including:

- **.NET:** Updated to the latest version.
- **Entity Framework:** Adapted to work with the most recent version of the ORM.
- **Bootstrap:** Updated to a modern version to ensure better responsiveness and usability.

These improvements have been applied to ensure that the code remains up-to-date and ready for use in current development environments.

## Technologies Used

- **ASP.NET Core MVC**
- **Entity Framework Core**
- **SQL Server**
- **Bootstrap**
- **C#**

## Project Features

- Seller and department registration
- Sales recording
- Sales reports by period
- Responsive web interface

## How to Run the Project

1. Clone the repository:

   ```bash
   git clone https://github.com/LucasDamasioDias/SalesWebMvc.git
   ```

2. Navigate to the project folder:

   ```bash
   cd SalesWebMvc
   ```

3. Restore dependencies:

   ```bash
   dotnet restore
   ```

4. Apply database migrations:

   ```bash
   dotnet ef database update
   ```

5. Run the application:

   ```bash
   dotnet run
   ```

6. Access in your browser:

   ```
   http://localhost:5000
   ```

## Project Structure

- `Controllers/` - Contains the application's controllers.
- `Models/` - Entity definitions and business rules.
- `Views/` - User interface files.
- `Data/` - Database configuration and migrations.

---

This project is an excellent opportunity to enhance knowledge in ASP.NET Core MVC and web development best practices.

