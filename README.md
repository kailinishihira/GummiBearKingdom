## Gummi Bear Kingdom

### Kaili Nishihira

#### _This a mock-up webpage about Gummi Bear Kingdom's products, 10.13.17_


## Description

_The user may create, read, update and delete products and the product's country of origin._

_Styling inspired by [Sugarfina](https://www.sugarfina.com/)._

|| Behavior  | Input  | Output  |
|---|---|---|---|
|1| You may add a Country of Origin to the database | Add a Country of Origin<br> <li>Country of Origin: Germany</li> | Germany was added to the database |
|2| All Countries of Origin will be displayed in the Index of the Countries View  | Click `Countries of Origin` on the navbar | A list of all Countries of Origin will be displayed |
|3| You may add a product to the database | Add a New Product<br> <li>Product Name: Champagne Gummies</li> <li>Product Description: Champagne infused gummies</li> <li>Product Cost: $5.00</li> <li>Select Country of Origin: Germany</li> | Champagne Gummies was added to the database |
|4| All products will be displayed in the Index of the Products View  | Click `Products` on the navbar | A list of products will be displayed |
|5| You may view the product details: description, cost and Country of Origin | In the Index of the Products View, click on `Champagne Gummies` | Champagne Gummies<br> Made in Germany<br> Champagne infused gummies<br> $5.00 |
|6| You may view all of the products made by their Country of Origin | In the Index of the Countries View, click on `Germany` | A list of all products made in Germany will be displayed |



## Setup/Installation Requirements

* _Download and install [.NET Core 1.1 SDK](https://www.microsoft.com/net/download/core)_
* _Download and install [MAMP](https://www.mamp.info/en/)_
* _Download and install [Visual Studio 2017](https://www.visualstudio.com/)_
* _Clone repository_

### Setup/Installation for Database
* Set MySQL Port number in appsettings.json and GummiBearContext.cs files
* In your terminal, navigate from the Solution folder to the project folder, GummiBearKingdom
* Enter `dotnet restore` in your terminal
* Enter `dotnet ef database udpate` in your terminal

## Technologies Used
* _C#_
* _.NET_
* _MVC_
* _Entity Framework_
* _[Bootstrap](http://getbootstrap.com/getting-started/)_
* _[MySQL](https://www.mysql.com/)_

### License

Copyright (c) 2018 **_Kaili Nishihira_**

*Licensed under the [MIT License](https://opensource.org/licenses/MIT)*


﻿
