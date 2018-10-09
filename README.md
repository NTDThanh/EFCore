# EFCore
For study entity framework core
I. Initial solution:

  1.Create project EFCore.Data:
      - Project type: Class Library.
      - Target framework: .NET Standard 2.0.
      - Install nugetpack: 
          + Microsoft.EntityFrameworkCore
          + Microsoft.EntityFrameworkCore.Tools
          + Microsoft.EntityFrameworkCore.Design
          + Microsoft.EntityFrameworkCore.Relational.Design
          + Microsoft.EntityFrameworkCore.SqlServer
      - Add reference to EFCore.Domain.
      
   2.Create project EFCore.Domain:
      - Project type: Class Library
      - Target framework: .NET Standard 2.0
      - Install nugetpack: 
          + System.ComponentModel.Annotations
          
   3.Create some UI project 
      - Project type: Winform, ASP.NET etc...
      - Target framework: .NET 4.6.1 or higher, .NET Core 2.xxx
      - Install nugetpack: 
          + Microsoft.EntityFrameworkCore
          + Microsoft.EntityFrameworkCore.Tools
          + Microsoft.EntityFrameworkCore.Design
          + Microsoft.EntityFrameworkCore.Relational.Design
          + Microsoft.EntityFrameworkCore.SqlServer
      
