using CalorieTracker.API.Model;

namespace CalorieTracker.API.Repository; 

public interface IIngredientRepository
{   
    IEnumerable<Ingredient> GetAllIngredients(); 
    IEnumerable<Ingredient> CreateNewIngredient(Ingredient newIngredient); 
    Ingredient UpdateIngredientById(Ingredient updateIngredient); 
    Ingredient GetIngredientById(int id);
    IEnumerable<Ingredient> GetIngredientByName(string name); 
    
}

public interface IMealRepository
{
    Meal GetMealById(int id); 
    Meal AddIngredientsToMeal(MealIngredient newMealIngredient, int mealId); 
    Meal CreateNewMeal(Meal newMeal); 
}