# Calorie Tracker

This is a Full Stack Web App made in .NET to help users track ingredients and calories in meals.  

## Project Members
- Alex Piccolo

## Project Requirements
- README that describes the application and its functionalities
- ERD of your DB
- The application should be ASP.NET Core application
- The application should build and run
- The application should have unit tests and at least 20% coverage (at least 5 unit tests that tests 5 different methods/functionality of your code)
- The application should communicate via HTTP(s) (Must have POST, GET, DELETE)
- The application should be RESTful API
- The application should persist data to a SQL Server DB
- The application should communicate to DB via EF Core (Entity Framework Core)

## Tech Stack

- C# (Back End Programming Language)
- SQL Server (Azure Hosted)
- EF Core (ORM Tech)
- ASP.NET (Web API Framework)

## User Stories
- User should be able to login/logout if they already have an account
- User should be able to register if they do not have an account
- User should be able to create a new showdown team
- User should be able to choose up to six Pokemon
- User should be able to customize stat totals, levels, move sets and held items for each Pokemon
- User should be able view all previous teams that they created
- User should be able to delete teams that they don’t need
- User should be able to have all data needed to import their team to Pokemon Showdown

## Tables
![ERD](./Calorie Tracker ERD.jpg)

## MVP Goals
 - Users can add and update ingredients, including such information as Name and Calories Per Gram. 
 - Users can also add and update meals, including the name of the meal, a list of ingredients used, and the quantity of that ingredient. 
 - Users can retrieve information about meals, such as total calories of ingredients, or quantity of specific ingredients. 


## Stretch Goals
- Implement login/logout and register functionality to allow for multiple users
- Segregate data by user: 
    - Simple: Associate users with meals/ingredients, so users can retrieve a list of meals by the user that created it
	- Stretch: Users can only access meals and ingredients that they have added