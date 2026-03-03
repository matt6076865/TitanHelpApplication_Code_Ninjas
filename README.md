Titan Help Desk Application by "Code Ninjas" Group - SPC Spring 2026:

Purpose: The Titan Help Desk is a centralized IT support portal designed for the SPC community. It provides a modern interface for students and faculty to report technical issues, while allowing administrators to manage, track, and resolve tickets efficiently.

The Code Ninjas Group
Matthew Watkins – Team Leader | Presentation Layer
Kenneth Fafrak – Developer | Application Layer
Adrian Diaz – Developer | Data Layer

Technology Stack
Frontend: ASP.NET Core Blazor
Backend Logic: C# Service Classes
Database: SQLite / Entity Framework Core
Tools: Visual Studio 2026, Git Bash, NuGet

License
This project is licensed only for SPC students and the Code ninjas group.

Architecture
The project follows a Three-Tier Architecture pattern to ensure a strict Separation of Concerns (SoC):
Presentation Layer: Built with Blazor WebAssembly, providing a modern, single-page application (SPA) experience.
Application Layer: A service-based buffer containing business logic and dependency injection.
Data Layer: Powered by Entity Framework Core with SQLite, utilizing a Code-First approach for seamless database evolution.

Features
Ticket Lifecycle Management: Full CRUD (Create, Read, Update, Delete) capabilities for support requests.
Real-time Dashboard: A dynamic overview of all active and resolved tickets.
Decoupled Architecture: A clean three-tier system ensuring scalability and maintainability.
Data Integrity: Implemented cascading deletes and strict input validation to prevent orphaned data.



