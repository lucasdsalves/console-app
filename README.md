# About 
This is a .NET 6 console app template ready to run.

# Project technologies
* .NET 6
* Console Application
* Dependency Injection
* Use of AppSettings
* Use of HostedService / CancellationToken
* <i>Prerequisites: .NET 6 Runtime, Visual Studio / Visual Studio Code </i><br />

# Project structure
ConsoleApp: the console app itself, with DI config, Program and hosted service;
Application: services and interfaces;
Data: Data and core entities persistence layer;
Tests: Tests layer.
  
# For someday reminder: Example of project creation using CLI (folders src and tests)
```
dotnet new sln
dotnet new classlib -o src/TemplateApp.Domain
dotnet new xunit -o tests/Domain.UnitTests
dotnet sln add src/TemplateApp.Domain
dotnet sln add tests/Domain.UnitTests
```
