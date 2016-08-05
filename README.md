DotNET FHIR

Winforms Application to interact with FHIR servers

## Requirements

  - Visual Studio 2013 and above
  - SQL Server 2008R2 Express and above
  - .NET 4.5 Framework
  - Nunit 3.0

## Getting Started
 - Open the solution and restore the nuget packages.
 - Goto solution properties and change single startup project to FHIR.Client.
 - Set Solution configuration to Release mode and Rebuild the application.
 - Run the Application.
 - Application might take a while to initialise for the first time.


### Usage
 - Add Patient tab to add new patients to the local DB.
 - Search/Manage Patients tab to manage the patients in local db.Delete only does soft delete.
 - FHIR tab to fetch and import data from test server. Data can be imported to local db after selecting the rows from the grid.



### Tech



* [Reactive Extensions] -  awesome library for composing asynchronous and event-based programs 
* [HL7 FHIR] - Api for Fast Healthcare Interoperability Resources.
* [Entity Framework] - ORM. 




### Tests

Download and install Nunit and GUI Test Runner (http://www.nunit.org/index.php?p=download).

Load the FHIRUnitTests.DLL from \FHIRUnitTest\bin\Debug
to run the unit tests.

### Todos

 - Rethink Github Save
 - Add Code Comments
 - Add Night Mode
 - Add Lot of Functionalities

