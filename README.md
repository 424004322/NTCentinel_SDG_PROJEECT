# NTCentinel: Automated Student Violation Management Kiosk

UN SDG Alignment: Goal 11 — Sustainable Cities & Communities
Language: VB.NET / WinForms (.NET Framework)
Database: Microsoft SQL Server (SqlClient Data Provider)

## 1. Project Overview
NTCentinel is a professional-grade, kiosk-based Windows Forms (WinForms) client desktop application developed in VB.NET for the National Teachers College (NTC) perimeters. This system acts as a high-speed, persistent, and secure utility that automates and digitizes the traditional logging of student behavioral and compliance infractions at physical campus entry gates. 

By replacing manual pen-and-paper logbooks with near-instant high-frequency QR matrix decoding and a unified backend database, NTCentinel establishes an efficient, real-time data synchronization link between peripheral security check-points and the central Office of Student Affairs (OSA) database infrastructure via ADO.NET pipelines.

---

## 2. UN Sustainable Development Goal Alignment

### Primary Focus: SDG 11 — Sustainable Cities and Communities
Target 11.7: Provide universal access to safe, inclusive and accessible, green and public spaces, in particular for women and children, older persons and persons with disabilities.

### The Solution:
Historically, manual gate checks created major pedestrian bottlenecks during morning rush hours, causing incoming students to crowd onto public sidewalks and outer city streets. This congestion generated immediate physical security vulnerabilities and vehicle-pedestrian hazards. 

By lowering entry identity validation and violation selection cycles down to a sub-3-second transaction threshold, NTCentinel eliminates outer street clustering, clears public right-of-ways, reduces traffic hazards, and ensures a highly structured, safe, and accessible public gateway ecosystem for the entire National Teachers College academic community.

---

## 3. System Architecture & Code-Behind Design
The application is engineered using a forms-centric desktop client-server framework optimized for Local Area Network (LAN) deployment. It utilizes modular object-oriented programming (OOP) logic classes, data tables, and structured properties to ensure a clean separation between user input interactions and data layer processes.

### Core Architectural Features:
* High-Speed Decoding Matrix: Connects programmatically to physical hardware scanners to capture, isolate, and interpret student QR payloads within a maximum processing latency of 1.0 second.
* ADO.NET (System.Data.SqlClient) Persistence: Eliminates data loss and security risks by processing database records over secure, fully parameterized query execution commands to prevent SQL Injection attempts.
* 3-Strike Automation Engine: Encapsulated in a dedicated business domain class module. It dynamically tracks cumulative historical offenses; if a student crosses the three-active-violation threshold, it triggers an immediate warning flag and updates the OSA Dashboard interface.
* System.Drawing Hardware Hook: Directly drives local thermal receipt modules using the native .NET System.Drawing.Printing namespace to produce physical, serialized infraction slips immediately upon data persistence.
* Microsoft Report Viewer Integration: Embedded directly within administrative reporting dashboards to compile comprehensive data trends, filter logs, and output clean summaries.

---

## 4. Technical Requirements Mapping

| Technical Parameter | Actual Implementation Structure |
| :--- | :--- |
| Logic Structure | Object-Oriented Programming (OOP) using custom Class modules, public Properties, and strict Function/Sub processing routines. |
| UI Environment | Windows Forms (WinForms) Client Terminal with strict naming conventions (e.g., btnConfirm, dgvViolations, lblStudentName). |
| Persistence Layer | Relational Database integration via ADO.NET (SqlClient) writing directly to Microsoft SQL Server. |
| Reporting Utility | Embedded Microsoft Report Viewer engine driving data summaries and compliance reports. |
| System Robustness | Comprehensive, structured Try-Catch-Finally blocks wrapping all external connection routes with descriptive MessageBox errors. |
| Input Validation | Explicit data-type checking (Numeric-only constraint, required string boundaries, and validation Regex arrays). |

---

## 5. Professional Team Responsibility Matrix

The architectural modules and individual implementation workloads are assigned to the project members as follows:

| Group Member Name | Assigned Software Engineering Layer | Domain Core Contribution & Subsystem Description |
| :--- | :--- | :--- |
| **Gracias, Kevin Jay C.** | Project Lead / Requirements & WinForms Interface Design | Led formal software requirements specification (SRS); designed highly visible, accessible touchscreen WinForms layouts, and configured control properties for perimeter security operators. |
| **Abayon, Rizal** | System Analyst / SDAD Documentation Specialist | Compiled and verified the comprehensive Software Design and Analysis Document (SDAD). Structured functional requirement indices and audited data maps against the target code implementation framework. |
| **Confiado, Amiel Paglinawan** | System Analyst / SDAD Data Modeling Specialist | Spearheaded architectural data tracking layouts within the SDAD. Transformed project boundaries into high-resolution Entity Relationship Diagrams (ERD) and Data Flow Diagrams (DFD). |

---

## 6. Technical Deployment and Execution Guide

Follow this definitive sequence to download the repository using Git, instantiate the physical database instance via the SQL script file, link the connection drivers, and build the solution executable.

### System Prerequisites
* Development Environment: Microsoft Visual Studio (Version 2019, 2022, or newer) with the ".NET Desktop Development" workload package selected during installation.
* Project SDK Framework: .NET Framework 4.7.2.
* Local Database Server: Microsoft SQL Server Express Edition or LocalDB instance.
* Extensions: Microsoft Report Viewer Projects Extension (acquired via the Visual Studio Extension Manager under Extensions > Manage Extensions).

### Step 1: Step-by-Step Guide to Clone the Repository
To clone the source code repository and its complete tracking tree onto your local development machine using Git, use the following operational steps:

1. Open your terminal application (Command Prompt on Windows, PowerShell, or Git Bash).
2. Verify that Git is installed on your computer system by typing the following validation command and pressing Enter:
   ```bash
   git --version
Navigate to the local directory pathway where you want to store the project folder (for example, your Documents or Development folder) using the change directory (cd) command:

Bash
cd C:\Users\YourUsername\Documents
Copy the official repository URL link from your GitHub page interface.

Execute the standard git clone expression, appending your copied URL link string:

Bash
git clone [https://github.com/YOUR_GITHUB_USERNAME/Group11_SDG11_NTCentinel.git](https://github.com/YOUR_GITHUB_USERNAME/Group11_SDG11_NTCentinel.git)
Press Enter. Git will automatically establish communication with the remote server, initialize a local target folder named Group11_SDG11_NTCentinel, download the complete architecture history, and cleanly extract the project files.

Change your terminal workspace execution focus into the newly created folder by using:

Bash
cd Group11_SDG11_NTCentinel
Step 2: Importing the Relational SQL Script File
To establish the tables, dependencies, and seed configurations inside your SQL Server instance, follow these instructions:

Launch SQL Server Management Studio (SSMS).

Authenticate and connect to your target database engine instance (e.g., .\SQLEXPRESS or (localdb)\MSSQLLocalDB).

Create a fresh, empty database shell by navigating to the Object Explorer sidebar, right-clicking on the Databases directory node, and selecting New Database. Name this database shell instance exactly: NTCentinel.

From the top task toolbar menu, select File > Open > File...

In the browse directory prompt window, navigate into the cloned project folder pathway and open: DATABASE/Database_Script.sql.

Ensure that the active Database Selection dropdown controller located on the top left utility menu toolbar is set to point at your newly initialized NTCentinel database target (instead of the system master database).

Click the Execute command button or press F5 on your physical keyboard layout. Verify that the tracking output window logs a successful message array showing that all relations (Student_Table, Violation_Record_Table, User_Table, Violation_Type_Record) were bound correctly without execution errors.

Step 3: Configuring the Application Connection Pipeline
Open your Microsoft Visual Studio software environment.

Choose File > Open > Project/Solution... from the primary user menu grid.

Navigate into the CODE/ tracking directory of your local project repository copy, choose the primary visual file wrapper ProjectSolution.sln, and click Open.

Locate the configuration data module inside the Solution Explorer layout view window. Locate the primary system property file named App.config (or your dedicated database connection utility class module).

Locate the XML <connectionStrings> parameter node array block and replace the value assigned to Data Source with your exact personal local SQL Server naming structure:

XML
<connectionStrings>
    <add name="NTCentinelDB" connectionString="Data Source=.\SQLEXPRESS;Initial Catalog=NTCentinel;Integrated Security=True;" providerName="System.Data.SqlClient" />
</connectionStrings>
Step 4: Solution Compilation and System Launch
Refresh compilation paths by navigating to the Build menu from the task header and selecting Clean Solution.

Follow up immediately by choosing Rebuild Solution to process data objects and compile form components cleanly.

Verify that the tracking compilation log reports no framework syntax errors, reference failures, or unresolved .NET packages.

Press F5 or click the primary Start execution control button to spin up the application window shell.

Log into the system using the pre-seeded account parameters provided within the relational data dictionaries to bypass access guards and populate the active WinForms user interfaces.

Developed as a Cyclical Requirement for IT Elective 1 (ITELEC1) — National Teachers College.
