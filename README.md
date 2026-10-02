# Student Management System 

Simple Student Management Sample (Sprint 5)

Overview
--------
This small .NET console application demonstrates basic object-oriented concepts in C#: inheritance, encapsulation, constructors (including copy constructor), properties with validation, static members, and method overriding.

Project purpose
---------------
- Show a base Person class and a derived Student class
- Validate property inputs (Name, Age, GPA) and throw exceptions on invalid values
- Track the number of Student instances using a static property
- Print information for a list of Person/Student objects

Prerequisites
-------------
- .NET 10 SDK installed
- Visual Studio 2026 or the `dotnet` command-line tools

How to run
----------
Using Visual Studio:
- Open the solution file: `SMS_Sprint5/SMS_Sprint5.slnx`
- Build and run the project (F5 or Ctrl+F5)

Using the command line:
- Open a terminal in the repository root (folder that contains `SMS_Sprint5`)
- Run:

	dotnet run --project SMS_Sprint5

Project structure
-----------------
- SMS_Sprint5/Program.cs  - demo program that creates Person and Student objects and prints info
- SMS_Sprint5/Person.cs   - base class with Name and Age properties and PrintInfo method
- SMS_Sprint5/Student.cs  - derives from Person; adds GPA, Validate logic, CalculateGrade, and StudentCount static

Behavior notes
--------------
- Name cannot be null or empty; Age cannot be negative. Invalid values throw ArgumentException.
- Student.GPA must be between 0 and 4 inclusive; invalid values throw ArgumentException.
- Student.StudentCount is incremented each time a Student instance is constructed (including via copy constructor).

Example output
--------------
Program prints each object's type and information, followed by the total Student count and any validation error messages caught in the demo.

License
-------
No license specified. Modify as needed.
