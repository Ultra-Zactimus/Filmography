# _Filmography: An Internet Movie Database_

#### By Tiffany Rodrigo, Drew Henderson and Zachary Green

#### _This is a project that demonstrates using Many-to-Many Relationships in mySQL using Microsoft Entity Framework. This project was possible under the guidance of Epicodus https://www.epicodus.com/_

## Technologies Used

* `C#`
* `Microsoft Entity Framework`
* `ASP.NET Core MVC`
* `Bootstrap`
* `CSS`

## Description

_Users can add movies, actors, directors or compaosers and tie their relationships together so that the details page will display information about all the actors part of a movie etc. Porject uses CRUD (Create, Read, Update, Destroy) functionality for the pages_

## Setup/Installation Requirements

<strong><em>Requirements for Running the Project in a Browser</em></strong>
#

Developer Note -- <em>You do not need to type in `$` into the terminal, the terminal starts with `$` on GitBash and `%` on Bash.</em>

* Visit https://github.com/Ultra-Zactimus/HairSalon.Solution
* Clone this repository to your desktop.
* Navigate to the top level directory in your terminal.
* Run "$ `touch appsettings.json`"
* Run "$ `code .`" to open the project in VS Code. If you do not have VS Code please visit their website: https://code.visualstudio.com/
* Add in this code to the `appsettings.json` file inside `VS Code`:
  `{
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR_MYSQL_PROJECTNAME];uid=root;pwd=[YOUR-PASSWORD-HERE];"
    }
  }`

* Create a gitignore file. Run "$ `touch .gitignore`" on the top level of the project.
* Inside of `VS Code` type in `appsettings.json` into the gitignore file. This will keep your password safe.
* Change the password to be the same password as your mySQL Server Password. If you do not have mySQL server please visit their website: https://www.mysql.com/


Developer Note -- <em>You do not need the square brackets around your password, that is only to demonstate where your password needs to be. For further instructions please scroll down below for a more detailed setup in the SQL Setup section</em>

* Run "$ `dotnet add package Microsoft.EntityFrameworkCore -v 5.0.0`"
* Run "$ `dotnet add package Pomelo.EntityFrameworkCore.MySql -v 5.0.0-alpha.2`"
* Run "$ `dotnet add package Microsoft.EntityFrameworkCore.Proxies -v 5.0.0`"
* Run "$ `dotnet restore`" to restore the bin and obj folders.
* Run "$ `dotnet tool install --global dotnet-ef --version 5.0.1`"
* Run "$ `dotnet build`" to build the project.`"
* Run "$ `dotnet ef migrations add Initial`"
* Run "$ `dotnet ef database update`"
* Run "$ `dotnet watch run`" to launch a LocalHost. Click on `LocalHost:5000`. You may have to hold Ctrl or Command when clicking it to get it to open in your internet broswer.


## Known Bugs

No known bugs at this time

## License

MIT

Copyright © 2022 Tiffany Rodrigo, Drew Henderson and Zachary Green