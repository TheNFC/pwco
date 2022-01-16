# pwco<h1 align="center">

<br>

<br>

<br>

</h1>

<h4 align="center">Employees Management Tool</h4>

<p align="center">
  <a >
    <img src=""
         alt="Screenshot">
  </a>
</p>

## Project Overview 🎉
Our web app was created for managing employees. Build in C# and ASP.NET Core technology, using Microsoft SQL DB host on Azure to store data. 
## Tech/framework used 🔧

| Tech                                                    | Description                              |
| ------------------------------------------------------- | ---------------------------------------- |
| [ASP.NET Core](https://docs.microsoft.com/pl-pl/aspnet/core/introduction-to-aspnet-core?view=aspnetcore-6.0)                         | ASP.NET Core is a free and open-source web framework and successor to ASP.NET, developed by Microsoft. It is a modular framework that runs on both the full.NET Framework, on Windows, and the cross-platform.NET.    |
| [Microsoft SQL Server](https://docs.microsoft.com/en-us/sql/sql-server/?view=sql-server-ver15)                          | Microsoft SQL Server is a relational database management system developed by Microsoft. As a database server, it is a software product with the primary function of storing and retrieving data as requested by other software applications.  |
| [SQL Azure](https://azure.microsoft.com/en-us/services/load-balancer/?&ef_id=EAIaIQobChMIwIT2guCz9QIVStiyCh3XaQonEAAYASAAEgIRLvD_BwE:G:s&OCID=AID2200242_SEM_EAIaIQobChMIwIT2guCz9QIVStiyCh3XaQonEAAYASAAEgIRLvD_BwE:G:s&gclid=EAIaIQobChMIwIT2guCz9QIVStiyCh3XaQonEAAYASAAEgIRLvD_BwE)                           | Microsoft Azure SQL Database is a managed cloud database provided as part of Microsoft Azure. A cloud database is a database that runs on a cloud computing platform, and access to it is provided as a service. Managed database services take care of scalability, backup, and high availability of the database.   |


## Screenshots 📺

<p align="center">
    <img src="" alt="Screenshot">
</p>

<p align="center">
    <img src="" alt="Screenshot">
</p>

<p align="center">
    <img src="" alt="Screenshot">
</p>

## Code Example/Issues 🔍
```C#
@using Microsoft.AspNetCore.Identity
@using pwco.Areas.Identity.Data

@inject SignInManager<IdentityUser> SignInManager
@inject UserManager<IdentityUser> UserManager

@if (!SignInManager.IsSignedIn(User))
{
    Context.Response.Redirect("/");
}
```
## Installation 💾

## Live 📍
URL to demo website: [CLICK](https://pwco20220113190332.azurewebsites.net/)
