![Public use photo of travel accoutrements](TravelApi/wwwroot/images/annie-spratt-qyAka7W5uMY-unsplash.jpg)
# Travel API 
### A template for a C# ASP.Net Core 6 MVC program 
#### By Henry Sullivan & Kirsten Opstad 

***
## Table of Contents
* [Technologies](#technologies)
* [Description](#description)
* [Objectives](#objectives)
* [Setup Instructions](#setup-installation-requirements)
* [API Documentation](#api-documentation)
* [License](#license)
***
## Technologies Used

* C#
* .Net 6
* ASP.Net Core 6 MVC
* EF Core 6
* SQL
* MySQL
* LINQ
* Swagger

***
## Description

Practice Building an API with travel reviews.

Prompt: Build an API that allows users to GET and POST reviews about various travel destinations around the world. Here are some user stories to get started. Note that you will have to create custom endpoints for some of these user stories.
***
## Objectives

### User Stories
* ✅ As a user, I want to GET and POST reviews about travel destinations.
* ✅ As a user, I want to GET reviews by country or city.
* ✅ As a user, I want to see the most popular travel destinations by number of reviews or by overall rating.
* ✅ As a user, I want to PUT and DELETE reviews, but only if I wrote them. (Start by requiring a user_name param to match the user_name of the author on the message. You can always try authentication later.)
* ✅ As a user, I want to look up random destinations just for fun.

<!-- ![Screenshot of Databases](imagelink) -->

<!-- [Link to operational site](http://www.kirstenopstad.github.com/<REPOSITORY NAME>) -->

### Goals
1. Meet MVP
2. Goal 2
3. Goal 3
***
## Setup Installation Requirements

### Open project
1. Navigate to the `Project Name` directory.
2. Create a file named `appsettings.json` with the following code. Be sure to update the Default Connection to your MySQL credentials.
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=[PROJECT-NAME];uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];",
  }
}
```
3. Install dependencies within the `Project Name` directory
```
$ dotnet restore
```

4. To build & run program in development mode 
 ```
 $ dotnet run
 ```

5. To build & run program in production mode 
 ```
 dotnet run --launch-profile "production"
 ```
***
## API Documentation
### __Endpoints__
```
 GET http://localhost:5000/api/v2/reviews
 POST http://localhost:5000/api/v2/reviews
 PUT http://localhost:5000/api/v2/reviews/{id}
 DELETE http://localhost:5000/api/v2/reviews/{id}
 ```
Note: The {id} value in the URL is a variable and should be replaced with the id number of the review the user wants to PUT or DELETE

### __Queries__
For GET http://localhost:5000/api/v2/reviews

Parameter   | Type  | Required | Description | 
|:---------|:---------:|:---------:|:---------|
Country | string | Not Required | Returns reviews with matching country value
City | string | Not Required | Returns reviews with matching city value
sortByRating | bool | Not Required | Sorts reviews from highest rating to lowest rating
sortByDescriptionCount | bool | Not Required | Sorts reviews by most popular destinations determined by number of reviews
random | bool | Not Required | Returns a random review

### __Example Queries__
The following query will return all reviews with the country value of "Mexico":

``` GET http://localhost:5000/api/v2/reviews?country=mexico ```

The following query will return all reviews with the city value of "Florence":

```GET http://localhost:5000/api/v2/reviews?country=florence```

The following query will return all reviews sorted from highest rating to lowest rating:

```GET http://localhost:5000/api/v2/reviews?sortByRating=true```

The following query will return all reviews by most popular destinations determined by number of reviews:

```GET http://localhost:5000/api/v2/reviews?sortByDescriptionCount=true```

The following query will return a random review:

```GET http://localhost:5000/api/v2/reviews?random=true```

It's possible to include multiple query strings by separating them with an &:

``` GET http://localhost:5000/api/v2/reviews?country=italy&city=florence ```

### __Endpoints that require userName__
PUT http://localhost:5000/api/v2/reviews/{id}

DELETE http://localhost:5000/api/v2/reviews/{id}


Parameter   | Type  | Required | Description | 
|:---------:|:---------:|:---------:|:---------|
userName | string | Required | A review may only be deleted if userName matches the Author of the review.


### __Endpoints that require body input__
PUT http://localhost:5000/api/v2/reviews/{id}

Parameter   | Type  | Required | Description
|:---------:|:---------:|:---------:|:---------|
userName | string | Required | A review may only be deleted if userName matches the Author of the review. 

__A body must be included when making a PUT request__
Ex.
```
    {
        "description": "Delicious food!",
        "country": "Spain",
        "city": "Barcelona",
        "rating": 5,
        "author": "Margot"
    }

```

* POST http://localhost:5000/api/v2/reviews
__A body must be included when making a PUT request__
Ex.
```
    {
        "description": "Delicious food!",
        "country": "Spain",
        "city": "Barcelona",
        "rating": 5,
        "author": "Harold"
    }

```

### __Note on Versioning__
There are two versions available for the TravelApi. Version 2.0 is the most up to date, and includes the 'random' endpoint. To revert back to version 1.0, simply replace v2 in the endpoint with v1.
For example: 

```
Version 2.0
GET http://localhost:5000/api/v2/reviews

Version 1.0
GET http://localhost:5000/api/v1/reviews
```


## Known Bugs

* No known bugs. If you find one, please email us at [kirsten.opstad@gmail.com](mailto:kirsten.opstad@gmail.com) or [sullivanbhenry@gmail.com](mailto:sullivanbhenry@gmail.com) with the subject **[_Repo Name_] Bug** and include:
  * BUG: _A brief description of the bug_
  * FIX: _Suggestion for solution (if you have one!)_
  * If you'd like to be credited, please also include your **_github user profile link_**

## License


MIT License

Copyright (c) 2023 Kirsten Opstad and Henry Sullivan

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
