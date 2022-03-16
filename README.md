# _Pierre's Bakery Statistics: My Ninth Code Review at Epicodus_

#### By Zachary Green

#### _This is a project that demonstrates using `ASP.Net Core MVC` to build out a project using Razor inline code in HTML and also seperation of classes, controllers for HTML Get and Post functionality and the use of Unit Testing with VSCode. This project was possible under the guidance of Epicodus https://www.epicodus.com/_

## Technologies Used

* `C#`
* `MSTest`
* `ASP.NET Core MVC`
* `Bootstrap`
* `CSS`

## Description

_Pierre is running a sucessful bakery and his pastries and bread are flying off the shelf. However, he needs a way to keep track of all his clients and how much each one is purchasing in a given day. This application is setup like how a website Database might function. The user can enter clients into the system and then click on their name to add extra details about that client to be stored and revisited later_

## Setup/Installation Requirements

`Running the project in a browser`

* Visit https://github.com/Ultra-Zactimus/BakeryStats.Solution
* Clone this repository to your desktop.
* Navigate to the `Bakery.Solution` production folder in the terminal and run $"`code .`" to open the project in `VS Code`.
* If you do not have `VS Code` please visit their website: https://code.visualstudio.com/ and follow their installation instructions.
* In `VS Code` open the `Terminal` and Navigate to `BakeryStats` folder.
* Run "$ `dotnet restore`" to restore the bin and obj folders.
* Run "$ `dotnet build`" to build the project.
* Run "$ `dotnet run`" or "$ `dotnet watch run`" to create a LocalHost live server inside the `VS Code` Terminal.
* Program will not launch immediately. You will have to click on `LocalHost:5000` to view the page in the browser.

`Running the tests for the project`

* In the terminal in VS Code, navigate to BakertStats.Tests folder.
* Run "$ `dotnet restore`" to rebuild the necessary `NuGet` dependancies for `MSTest`.
* Then Run "$ `dotnet test`", this will show how many tests and whether they passed or failed. By default the tests should be all in passing. If you would like to try out what a failure looks like, open either `OrderTests.cs` or `VendorTests.cs` in `VS Code`.
* Pick any test to make change to that you would like with the `[TestMethod]` above it. Inside the `Assert.AreEqual()`, change the first value to something else.
* Now run "$ `dotnet test`". The message should appear in Red and tell you that it `Expected:` the value you have enter, but the `Actual:` value is not the same.
* Please make suer to change any changes made back to what they were before trying to build the project again to avoid errors.

--Developer Note--<em>You do not need to type in $ into the terminal, the terminal starts with $ on GitBash and % on Bash.</em>

## Known Bugs

No known bugs at this time

## License

MIT

Copyright © 2022 Zachary Green