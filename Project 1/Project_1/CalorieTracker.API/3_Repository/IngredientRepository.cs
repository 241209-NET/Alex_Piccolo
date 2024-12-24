using CalorieTracker.API.Data;

namespace CalorieTracker.API.Repository; 

public class IngredientRepository : IIngredientRepository
{
    private readonly CalorieTrackerContext _calorieTrackerContext; 

    public IngredientRepository(CalorieTrackerContext calorieTrackerContext) => _calorieTrackerContext = calorieTrackerContext; 

    //Start writing Repo CRUD operations

}