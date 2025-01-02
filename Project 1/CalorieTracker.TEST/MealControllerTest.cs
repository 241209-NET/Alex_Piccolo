using Moq; 
using CalorieTracker.API.Model; 
using CalorieTracker.API.Repository; 
using CalorieTracker.API.Service; 

namespace CalorieTracker.TEST; 

public class MealControllerTest
{
    /*
    [Theory]//maybe change? 
    //add relevant inline data, ex: 
    [InlineData(1, false)]
    public void testName(int n, bool expected)//change inputs as needed
    { 
        //Arrange

        //Act

        //Assert

    }*/

    [Fact]
    public void TestCreateNewMeal()
    {
        //Arrange
        Mock<IMealRepository> mockRepo = new(); 
        MealService mealService = new(mockRepo.Object); 

        List<Meal> mealList = [
            new Meal{Id = 1, Name = "Pie"},
            new Meal{Id = 2, Name = "Strudel"}
        ];

        Meal newMeal = new Meal{Id = 3, Name = "Taco"}; 

        mockRepo.Setup(mockRepo => mockRepo.CreateNewMeal(It.IsAny<Meal>()))
            .Callback((Meal m) => mealList.Add(m)); 
            //.Returns(newMeal); 

        //Act
        var myMeal = mealService.CreateNewMeal(newMeal); 

        //Assert
        Assert.Contains(newMeal, mealList); 
        mockRepo.Verify(x => x.CreateNewMeal(It.IsAny<Meal>()), Times.Once());

    }

    [Fact]
    public void GetAllMealsTest()
    {
        //Arrange
        Mock<IMealRepository> mockRepo = new();
        MealService mealService = new(mockRepo.Object);

         List<Meal> mealList = [
            new Meal{Id = 1, Name = "Pie"},
            new Meal{Id = 2, Name = "Strudel"}
        ];

        mockRepo.Setup(repo => repo.GetAllMeals()).Returns(mealList);
        
        //Act
        var result = mealService.GetAllMeals().ToList();
        
        //Assert
        Assert.Equal(mealList, result);
    }

    //test meals
    



    //Additional instructions included in the project 1 setup document 

    //Generate test coverage

    //dotnet test --collect: "XPlat Code Coverage"

    //will generate test results folder (new one each time you run)
        // - find the GUID of the test coverage folder (the long gibberish string)
        //reportgenerator -reports:".\TestResults\c0ff3595-24fc-4dca-81db-e566f7046665\coverage.cobertura.xml" -targetdir:"coveragereport" -reporttypes:Html -classfilters:"+CalorieTracker.API.Service.*"
        //will generate the coverreport folder
            // - open index.html to see reportrepo
        //Reuirement: only need to test Services (should be the only files w/logic)

}