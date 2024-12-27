using Moq; 

namespace CalorieTracker.TEST; 

public class IngredientControllerTest
{
    [Theory]//maybe change? 
    //add relevant inline data, ex: 
    [InlineData(1, false)]
    public void testName(int n, bool expected)//change inputs as needed
    { 
        //Arrange

        //Act

        //Assert

    }

    //Additional instructions included in the project 1 setup document 

    //Generate test coverage

    //dotnet test --collect: "XPlat Code Coverage"

    //will generate test results folder (new one each time you run)
        // - find the GUID of the test coverage folder (the long gibberish string)
        //reportgenerator -reports:".\TestResults\<GUID>\coverage.cobertura.xml" -targetdir:"coveragereport" -reporttypes:Html
        // -classfilters:"+CalorieTracker.API\Service.*"
        //will generate the coverreport folder
            // - open index.html to see report
        //Reuirement: only need to test Services (should be the only files w/logic)

}