using CalorieTracker.API.Model;
using CalorieTracker.API.Repository;

namespace CalorieTracker.API.Service; 

public class MealService : IMealService
{
    public readonly IMealRepository _mealRepository; 
    
    public MealService(IMealRepository mealRepository) => _mealRepository = mealRepository; 

    //Note: Only the services should have the logic! They are the only thing we test! 
    //if you write utilities you need to test those too
    //need to test 20% of logic

    //Add Ingredients to the Meal
    public Meal AddIngredientsToMeal(MealIngredient addMealIngredient, int mealId)
    {
        //retrieve the meal based on input id
        return _mealRepository.AddIngredientsToMeal(addMealIngredient, mealId); 
        
    }

    public Meal CreateNewMeal(Meal newMeal)
    {
        return _mealRepository.CreateNewMeal(newMeal); 
    }

    //Get Meal By Id
    public Meal GetMealById(int id)
    {
        //Add logic to ensure id is not null
        return _mealRepository.GetMealById(id); 
    }
}