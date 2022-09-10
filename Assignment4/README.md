# A Simple Windows Forms GUI Application

### Usage
- Open the Project Management solution in Visual Studio
- Right click on the solution in Visual Studio and click on Restore NuGet Packages. This should install MySql.Data and System.Data.SqlClient packages that are required by the program.
- Build and Run. Close and reopen the solution if there are any issues with SQL related keywords.
### Requires: .NET 6.0

### Features
#### Basic Features
- Add, update and delete products
- Search from all added products
- View Products in the form of mini product cards
- View details separately from the list of products
- Retrieve products even after closing the application if a database server is chosen as a means of storage

#### Extra Features
- Search with regular expressions and multiple results
- All related forms are children of a single MDI form, details page included
- Multiple storage methods based on the user's choice
- Creates a database and a table so the user isn't required to take any database backend actions
- Exception handling wherever possible for a better UX
- Includes 4 projects under one solution, namely:
	- The Main Menu
	- MSSQL Storage
	- With MySQL Storage
	- With RAM Storage
	- All Projects can be run separately from their own solution files if needed.


### Windows Forms Controls Used
- `Label`
- `Button`
- `Textbox`
- `Date and Time Picker`
- `Error provider`
- `Checkbox`
- `Radio box`
- `MenuStrip`
- `Panel`
- `FlowLayoutPanel`
- `Table LayoutPanel`
- Also utilizes a User Control in the form of a Product Card.

## Screenshots
<img src="https://i.imgur.com/BhzcpIB.png"/>
<img src="https://i.imgur.com/Ptl5mpo.png"/>
<img src="https://i.imgur.com/1WpWZa3.png"/>
<img src="https://i.imgur.com/IbHNe70.png"/>
<img src="https://i.imgur.com/reVac0a.png"/>
<img src="https://i.imgur.com/u1Lcupv.png"/>
<img src="https://i.imgur.com/VyO4fxe.png"/>
Different color schemes for different storage methods (MySQL and RAM respectively) 
	- <img src="https://i.imgur.com/sGV1gqN.png"/>




