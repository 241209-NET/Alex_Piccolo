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

    //retrieve all meals
    public IEnumerable<Meal> GetAllMeals()
    {
        return _mealRepository.GetAllMeals(); 
    }

    //list all MealIngredients in meal
    public IEnumerable<MealIngredient> ListAllIngredients(int mealId)
    {
        //does this work? 
        var ingredientList = _mealRepository.GetMealById(mealId).IngredientList; 
        return ingredientList; 
    }

    //Add Ingredients to the Meal
    public Meal AddIngredientsToMeal(MealIngredient addMealIngredient, int mealId)
    {
        //retrieve the meal based on input id
        return _mealRepository.AddIngredientsToMeal(addMealIngredient, mealId); 
        
    }

    //remove ingredient from the meal
    public Meal RemoveMealIngredientById(int mealId, int ingredientId)
    {
        return _mealRepository.RemoveMealIngredientByMealId(mealId, ingredientId); 
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

    //List total calories in meal
    public double GetMealTotalCalories(int mealId)
    {
        var ingredientList = _mealRepository.GetMealById(mealId).IngredientList; 
        double sum = 0; 
        foreach(MealIngredient ingredient in ingredientList)
        {
            sum += (ingredient.Quantity * ingredient.IngredientWithQuantity.CaloriesPerGram); 
        }

        return sum; 
    }

    //delete meal
    public Meal DeleteMealById(int id)
    {
        return _mealRepository.DeleteMealById(id); 
    }


}