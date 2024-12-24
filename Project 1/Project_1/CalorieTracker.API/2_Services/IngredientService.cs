using CalorieTracker.API.Repository;

namespace CalorieTracker.API.Service; 

public class IngredientService : IIngredientService
{
    public readonly IIngredientRepository _ingredientRepository; 
    
    public IngredientService(IIngredientRepository ingredientRepository) => _ingredientRepository = ingredientRepository; 

    //Note: Only the services should have the logic! They are the only thing we test! 
    //if you write utilities you need to test those too
    //need to test 20% of logic
}