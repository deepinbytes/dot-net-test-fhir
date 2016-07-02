Requirements:
Visual Studio 2013 and above
SQL Server 2008R2 Express and above
.NET 4.5 Framework
Nunit 3.0

Getting started
1.Open FHIRClientApp present in the Release folder


Getting Started using solution:
1.Open the solution (FHIR Patient.sln) in Visual studio and restore the nuget packages if missing.
2.Goto solution properties change single startup project to FHIR.Client
3.Set Solution configuration to release mode and rebuild the application.
3.Run the Application
4.Application might take a while to initialise as the db for the first time run.

Usage:
1.Add Patient tab to add new patients to the local DB.
2.Search/Manage Patients tab to manage the patients in local db.Delete only does soft delete.
3.FHIR tab to fetch and import data from test server. Data can be imported to local db after selecting the rows from the grid.

Testing:
Install Nunit GUI Test runner and load the FHIRUnitTests.DLL from \FHIRUnitTest\bin\Debug
to run the unit tests.
