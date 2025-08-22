# Library App

## Description

Library App is a modular C# application designed to manage library operations such as patron management, book loans, and inventory. The project is organized into core, infrastructure, and console layers, following clean architecture principles for maintainability and testability.

## Project Structure

- AccelerateDevGHCopilot.sln
- README.md
- src/
    - Library.ApplicationCore/
        - Library.ApplicationCore.csproj
        - Entities/
        - Enums/
        - Interfaces/
        - Services/
    - Library.Console/
        - appSettings.json
        - CommonActions.cs
        - ConsoleApp.cs
        - ConsoleState.cs
        - Library.Console.csproj
        - Program.cs
        - Json/
    - Library.Infrastructure/
        - Library.Infrastructure.csproj
        - Data/
- tests/
    - UnitTests/
        - LoanFactory.cs
        - PatronFactory.cs
        - UnitTests.csproj
        - ApplicationCore/

## Key Classes and Interfaces

- **Library.ApplicationCore**
    - `Entities/`  
      Contains core domain models such as `Patron`, `Book`, `Loan`, etc.
    - `Interfaces/`  
      Defines repository and service interfaces, e.g., `IPatronRepository`, `ILoanService`.
    - `Services/`  
      Implements business logic for library operations.

- **Library.Infrastructure**
    - `Data/`  
      Provides concrete implementations for data access, such as `JsonPatronRepository`, `JsonLoanRepository`.

- **Library.Console**
    - `ConsoleApp.cs`  
      Main class for the console UI, orchestrating user interaction.
    - `Program.cs`  
      Application entry point, configures dependency injection and starts the app.
    - `CommonActions.cs`, `ConsoleState.cs`  
      Define enums and helpers for console navigation and actions.

- **tests/UnitTests/**
    - `LoanFactory.cs`, `PatronFactory.cs`  
      Test data factories for unit testing.
    - `ApplicationCore/`  
      Contains unit tests for core logic.

## Usage

1. **Build the Solution**
   - Open the solution file `AccelerateDevGHCopilot.sln` in Visual Studio or VS Code.
   - Build the solution to restore dependencies and compile all projects.

2. **Run the Application**
   - Set `Library.Console` as the startup project.
   - Run the application. The console UI will guide you through library management tasks.

3. **Configuration**
   - Edit `src/Library.Console/appSettings.json` to configure JSON data file paths.

4. **Testing**
   - Navigate to the `tests/UnitTests` directory.
   - Run unit tests using your preferred test runner.

## License

This project is licensed under the MIT