# TitanHelpApplication
Team name: Titan Developers
By Matthew Watkins, Andrian Diaz, Kenneth Fafrak IV 
(c) 2026 ALL RIGHTS RESERVED BY DEVELOPERS.

Group Programming Project - TitanHelp Application

Objectives
Demonstrate mastery of layered architecture patterns (Presentation, Application, Data Access)
Apply appropriate frameworks for each architectural layer
Practice professional software development workflows using Git and GitHub
Collaborate effectively in a distributed development environment
Document and communicate technical decisions

Formation
Group Requirements
Team Size: 3-4 
Team Name: Choose a professional team name
Group Leader: Designate one member as the primary point of contact
Sign-up: Use the designated discussion board to form teams

Group Leader Responsibilities
Coordinate team meetings and decisions
Submit weekly status reports via email
Serve as primary contact for instructor communication
Ensure equitable work distribution
Manage GitHub repository access and organization
GitHub Collaboration Requirements

Repository Setup
Repository Creation: Group leader creates a single GitHub repository for the team
Repository Naming: Use format titanhelp-[team-name] (e.g., titanhelp-code-warriors)
Team Access: Add all team members as collaborators with write access

Development Workflow
Feature Branches: Each developer must work on feature branches, not directly on main
Branch Naming: Use descriptive names: feature/presentation-layer, feature/data-access, bugfix/ticket-validation
Pull Requests: All code must be integrated via pull requests with at least one team member review
Commit Messages: Use clear, descriptive commit messages following conventional commit format
Documentation: Maintain a comprehensive README.md with setup instructions
Individual Contribution Tracking
Your grade will be partially based on your individual contributions visible through:

Commit History: Regular, meaningful commits with clear authorship
Pull Request Activity: Creating and reviewing pull requests
Code Ownership: Primary responsibility for your assigned layer
Issue Management: Using GitHub Issues to track tasks and bugs
Documentation: Contributing to project documentation and code comments
Individual Layer Assignments
Each team member must take primary responsibility for one architectural layer:

Presentation Layer Developer
Responsibilities: User interface, user experience, client-side validation
Technologies: Choose appropriate framework (React, Angular, Vue, Razor Pages, WPF, etc.)
Deliverables: Complete UI implementation, user interaction handling, responsive design
Application/Business Logic Layer Developer
Responsibilities: Business rules, workflow coordination, validation logic
Technologies: Service classes, controllers, business objects (POCOs/POJOs)
Deliverables: Ticket management logic, validation rules, API endpoints (if applicable)
Data Access Layer Developer
Responsibilities: Database interactions, data persistence, query optimization
Technologies: ORM framework (Entity Framework, Hibernate, SQLAlchemy, Mongoose)
Deliverables: Database schema, repository pattern, data access abstraction
Technical Requirements
Core Application: TitanHelp Ticket System
Build a help desk ticket management system with the following functionality:

Features
Ticket Display: Show all existing help desk tickets in a list/table format
Create Ticket: Form-based ticket creation with validation
Ticket Storage: Persist tickets to a database using appropriate ORM
Ticket Data Model
Ticket:
- ID (auto-generated)
- Name (required, max 100 characters)
- Date (auto-populated with creation date)
- Problem Description (required, max 1000 characters)
- Status (default: "Open")
- Priority (Low/Medium/High)
Technical Implementation
Database: Any relational database (SQLite for development acceptable)
Architecture: Clear separation of concerns across all layers
Error Handling: Comprehensive error handling and user feedback
Validation: Both client-side and server-side validation
Framework Requirements by Technology Stack
Choose one technology stack:

.NET Stack
Presentation: ASP.NET Core MVC, Razor Pages, or Blazor
Application: Service classes with dependency injection
Data Access: Entity Framework Core with Code First approach
