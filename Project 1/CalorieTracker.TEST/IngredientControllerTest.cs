using Moq; 
using CalorieTracker.API.Model; 
using CalorieTracker.API.Repository; 
using CalorieTracker.API.Service; 

namespace CalorieTracker.TEST; 

public class IngredientControllerTest
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
    public void TestCreateNewIngredient()
    {
        //Arrange
        Mock<IIngredientRepository> mockRepo = new(); 
        IngredientService ingredientService = new(mockRepo.Object); 

        List<Ingredient> ingredientList = [
            new Ingredient{Id = 1, Name = "Cheese", CaloriesPerGram = 20},
            new Ingredient{Id = 2, Name = "Apple", CaloriesPerGram = 13}
        ];

        Ingredient newIngredient = new Ingredient{Id = 3, Name = "Tomato", CaloriesPerGram = 2}; 

        mockRepo.Setup(mockRepo => mockRepo.CreateNewIngredient(It.IsAny<Ingredient>()))
            .Callback((Ingredient ing) => ingredientList.Add(ing)); 
            //.Returns(newIngredient); 

        //Act
        var myIngredient = ingredientService.CreateNewIngredient(newIngredient); 

        //Assert
        Assert.Contains(newIngredient, ingredientList); 
        mockRepo.Verify(x => x.CreateNewIngredient(It.IsAny<Ingredient>()), Times.Once());

    }

    [Fact]
    public void GetAllIngredientsTest()
    {
        //Arrange
        Mock<IIngredientRepository> mockRepo = new();
        IngredientService ingredientService = new(mockRepo.Object);

         List<Ingredient> ingredientList = [
            new Ingredient{Id = 1, Name = "Cheese", CaloriesPerGram = 20},
            new Ingredient{Id = 2, Name = "Apple", CaloriesPerGram = 13}
        ];

        mockRepo.Setup(repo => repo.GetAllIngredients()).Returns(ingredientList);
        
        //Act
        var result = ingredientService.GetAllIngredients().ToList();
        
        //Assert
        Assert.Equal(ingredientList, result);
    }

    //get ingredient by id
      public void GetIngredientByIdTest()
    {
        //Arrange
        Mock<IIngredientRepository> mockRepo = new();
        IngredientService ingredientService = new(mockRepo.Object);

        /* List<Ingredient> ingredientList = [
            new Ingredient{Id = 1, Name = "Cheese", CaloriesPerGram = 20},
            new Ingredient{Id = 2, Name = "Apple", CaloriesPerGram = 13}
        ];*/

        Ingredient findIngredient = new Ingredient{Id = 3, Name = "Tomato", CaloriesPerGram = 2}; 
        var ingredientId = findIngredient.Id; 
        //ingredientList.Add(findIngredient); 

        mockRepo.Setup(repo => repo.GetIngredientById(ingredientId)).Returns(findIngredient);
        
        //Act
        var result = ingredientService.GetIngredientById(ingredientId); 
        
        //Assert
        Assert.Equal(findIngredient, result);
    }
    



    //Additional instructions included in the project 1 setup document 

    //Generate test coverage

    //dotnet test --collect: "XPlat Code Coverage"

    //will generate test results folder (new one each time you run)
        // - find the GUID of the test coverage folder (the long gibberish string)
        //reportgenerator -reports:".\TestResults\c0ff3595-24fc-4dca-81db-e566f7046665\coverage.cobertura.xml" -targetdir:"coveragereport" -reporttypes:Html
        // -classfilters:"+CalorieTracker.API\Service.*"
        //will generate the coverreport folder
            // - open index.html to see reportrepo
        //Reuirement: only need to test Services (should be the only files w/logic)

}