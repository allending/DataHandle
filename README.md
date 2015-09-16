# DataHandle

## Summary
A dll library (built using c#) that uses Entity Framework to consume SQL Server databases.

This repository has 2 parts :-
1. The library itself "DataHandle"
2. An example use "DataHandleExample"

* These codes were developed on a windows 10 machine using visual studio 2013.
* The library only includes user and user access control related models 

## Prerequisites
1. .Net Framework 4.5 
2. Entity Framework 6


## Library Components

### Core
Focuses on the context, definition and shared features of the library.

### Models
The library has models, which represent the business processes' entities. They are data container classes that is used to  map the tables in the sql server database. 

### Entities
Entities consumes the core components' functions to yield / project results and modify data using the models. 
These can be used by other applications / services to fullfil the solutions' requirement.

### Getting started
1. Clone the repository
2. Open the DataHandleExample project and make sure that the DataHandle.dll is  referenced 
3. Create sample tables using the UAC.sql (included in the DataHandleExample directory)
4. Specify the connection paramater for "MyConnectionString" in the App.config
5. The sample is now ready to be used!!
