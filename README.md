# Zoo Bazaar

This is a collaborative project for which we were given a situation of a zoo that faces multiple management difficulties and has an improper and outdated administrative system. We had to define the problems and build an IT solution that would improve the current situation of zoo (see more details in Documentation/Project Plan). Our solution consists of a desktop application that supports multiple account types and handle animal and employee data, provide both automized and manual scheduling, support animal transfers and zoo collaboations. We also created a web application designed for the general public with the purpose of promoting the zoo and encouraging people to buy tickets. The website also supports schedule overview for caretakers (one type of employee).
<br/><br/>Team size: 4 people, Project duration: 18 weeks

## Account Types
The desktop application supports five different account types with custom interfaces: 
1. **HR Administration**: assigned with employee data management and account creation for the platform
2. **Animal Administration**: assigned with animal data management and animal transfers
3. **Schedule Maker**: supervise schedule making and holiday or sick leave requests
4. **Resource Planner**: supervise task assignment and caretakers activity
5. **Ticket Supervisor**: tasked with the check-in and check-out of visitors's tickets
<br/>

The web application supports one account type as well as anonymous activity for the general audience:
1. **Care Taker**: tasked with completing animal related activities
2. **No account**: the general audience has access to public pages and ticket reservation

## Desktop Application Features
* Full CRUD operations for employee data (separation of personal details, contract details and emergency contact details for different access levels)
* Full CRUD operations for animal data
* Supports animal transfer creation and transfer history
* Automatic shift generation
* Automatic task assignment
* Holiday and sick leaves approval
* Ticket check-in and check-out using a barccode reader

## Web Application Features
* Overview of general zoo information
* Image carousels for different zoo areas
* Real-time statistics (current numbers of animals, employees and visitors)
* Ticket purchasing and invoice generation
* Schedule overview (for caretakers after logging in)

## Programming Languages

* C# .NET Framework for backend
* Windows Forms Library for the desktop application
* ASP.NET Razor Pages for the web application
* MS SQL for data persistance (easily generate the database by running the script.sql)

## Application Development
- For the first 6 weeks, the team followed the Waterfall Methodology for which we devised together with our client a Project Plan that we strictly followed. The rest of the project we followed the Agile Methodology with 2-week iterations. We managed to improve already exiting features, as well as adding completely new ones ccording to our client's needs.
- We followed a clean 3-layer architecture consisting of presentation layer, logic layer and data layer
- The code strictly abides the SOLID design principles, making the application future proof and maintainable, offering the possibility of easily adding new features or account types
- The database uses a table-per-type approach
