# Local Business API
***

#### An ASP.NET Core API to track local businesses
<br>

### Created By: Chynna Lew

***

## Technologies Used

* C#
* .NET 5
* NuGet
* ASP.NET Core
* Entity Framework Core
* MySql
* MySql Workbench
* PostMan
* Swagger
***
## Description

This API stores information about local shops and restaurants in Portland, Oregon.  The API has full CRUD functionality and is documented with Swagger. 
<br> This API was created as an independent project at Epicodus to demonstrate understanding of API creation with ASP.NET Core and mySql. The project requirements are:
- The API includes full CRUD functionality
- One of the following further exploration topic has been implemented (or proof that significant time was spent attempting implementation)
  - Authentication
  - Versioning
  - Pagination
  - Swagger Documentation
  - CORS
- Complete documentation of API endpoints and the chosen further exploration

#### The corresponding MVC application can be found [here](https://github.com/chynnalew/LocalBusinessClient.Solution)
***

## Setup and Usage Instructions

### Technology Requirements

* Download and install [.NET 5](https://dotnet.microsoft.com/download/dotnet/5.0)
* Download and install a code text editor. Ex: [VS Code](https://code.visualstudio.com/)
* Download, install, and complete setup for [MySql Community Server](https://dev.mysql.com/downloads/file/?id=484914) and [MySql Workbench](https://dev.mysql.com/downloads/file/?id=484391).

### Installation

* Clone [this](https://github.com/chynnalew/LocalBusiness.Solution) repository, or download and open the Zip on your local machine
* Open the LocalBusiness.Solution folder in your preferred text editor
* To install required packages, navigate to LocalBusiness.Solution/LocalBusiness in the terminal and type the following commands:
  - dotnet add package Microsoft.EntityFrameworkCore -v 5.0.0
  - dotnet add package Pomelo.EntityFrameworkCore.MySql -v 5.0.0-alpha.2
  - dotnet add package Microsoft.EntityFrameworkCore.Proxies -v 5.0.0
  - dotnet tool install --global dotnet-ef --version 3.0.0
* Create a file named "appsettings.json" in the LocalBusiness directory
  - add the following code to the appsettings.json file:
```
{
  "Logging": {
    "LogLevel": {
      "Default": "Warning",
      "System": "Information",
      "Microsoft": "Information"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=local_business;uid=root;pwd=[YOUR-PASSWORD-HERE];"
  }
}
```
  - replace [YOUR-PASSWORD-HERE] with your unique MySql password
* Launch the MySql server:
  - In the terminal, run the command `$ mySql -uroot -p[YOUR-PASSWORD-HERE]`, replacing [YOUR-PASSWORD-HERE] with your unique MySql password
* To Import the API database to mySql:
  - In the terminal, navigate to LocalBusiness.Solution/LocalBusiness and run the command:
    - dotnet ef database update
* To Make Changes to the API Database:
  - If you would like to change the database, make changes in the proper models files, then run the following commands in the terminal navigated to LocalBusiness.Solution/LocalBusiness:
    - `dotnet ef migrations add YourDescriptionHere`
    - `dotnet ef database update`
* To Restore, build, and launch the API:
  - Navigate to the LocalBusiness.Solution/LocalBusiness folder in the command line or terminal
    - Run the command `$ dotnet restore` to restore the project dependencies
    - Run the command `$ dotnet build` to build and compile the project
    - Run the command `$ dotnet run` to build and compile the project
    - Calls can be made to the API in [Postman](https://www.postman.com/) with the address "http://localhost:5000/api/LocalBusinesses" 

## Review API Endpoints

- Base URL: `http://localhost:5000`
- Add HTTP Requests to the end of the Base URL to query the API

#### HTTP Requests
```
GET /api/LocalBusinesses
POST /api/LocalBusinesses
GET /api/LocalBusinesses/{id}
PUT /api/LocalBusinesses/{id}
DELETE /api/LocalBusinesses/{id}
```
#### Path Parameters
| Parameter | Type | Description |  
| :---: | :---: | --- |
| Name | string | Returns any business by name|  
| Type | string | Returns any business by type (shop or restaurant) |  
| Genre | string | Returns any business by genre (ex: Mexican/ Thai/ Korean restaurants, Music/ Clothing/ Thrift stores)|  
| Price | int | Returns any business by price range(1-5, with 1 = less expensive, 5 = very expensive) |     

#### Example Query
```
http://localhost:5000/api/LocalBusinesses?name=Ole%20Ole
```

#### Sample JSON
```
    {
      "businessId": 0,
      "name": "Ole Ole",
      "type": "Restaurant",
      "genre": "Mexican",
      "address": "2137 E Burnside St, Portland, OR 97214",
      "description": "A family owned mexican restaurant with good burritos. Cash only",
      "price": 1
    }
```

#### Swagger Instructions
This API uses [Swagger](https://swagger.io/tools/swagger-ui/) REST API Documentation
- Navigate to the following url to access Swagger:
```
http://localhost:5000/index.html
```
  - NOTE: the program must be running to access Swagger
The "LocalBusiness" tab contains example GET, POST, PUT, and DELETE queries
- To Test a query, find the tab for the query type and click the "Try It Out" button located in the top right corner of the card
  - This will allow inputs in the tab's form fields
  - Enter your query in the form field(s) and click the "Execute" button to view the server responses
***
## Known Bugs

* none at this time
***
### License

[MIT License](https://opensource.org/licenses/MIT)
Copyright 2021 Chynna Lew

***

## Support and contact details

* [Chynna Lew](github.com/chynnalew) 
* <ChynnaLew@yahoo.com>

<em style="color:grey">README structure created by Chynna Lew and Paige Tiedeman</em>
