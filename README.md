# DataHandle

## Summary
A dll library (built using c#) that uses Entity Framework to consume SQL Server databases.

This repository containes 2 parts
1. The library itself "DataHandle"
2. An example use "DataHandleExample"

* These codes were developed on a windows 10 machine using visual studio 2013
* The library only includes user and user access control related models 

## Prerequisites
1. .Net Framework 4.5 
2. Entity Framework 6


## Library Components

### Core
Focuses on the context, definition, shared features of the library

### Models
The library has models, the entities the represent the components belonging to business processes. These are data container classes that maps to the tables in the sql server database. 

### Entities
Entities consumes the core components functions to accomodate the result using the models. 
These can be used by external components' services to accomodate the application's requirement.

### Getting started
1. Clone / fork the repository
2. Open the DataHandleExample project and make sure that the DataHandle.dll is  reference 
3. Create sample tables using the UAC.sql (included in the DataHandleExample directory)
4. Specify the connection paramater for "MyConnectionString" in the App.config
5. The sample is now ready to be used!!
