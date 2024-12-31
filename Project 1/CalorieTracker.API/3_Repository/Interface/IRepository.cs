using CalorieTracker.API.Model;

namespace CalorieTracker.API.Repository; 

public interface IIngredientRepository
{   
    IEnumerable<Ingredient> GetAllIngredients(); 
    IEnumerable<Ingredient> CreateNewIngredient(Ingredient newIngredient); 
    Ingredient UpdateIngredientById(Ingredient updateIngredient); 
    Ingredient GetIngredientById(int id);
    IEnumerable<Ingredient> GetIngredientByName(string name); 
    Ingredient DeleteIngredientById(int id); 
    
}

public interface IMealRepository
{
    IEnumerable<Meal> GetAllMeals(); 
    Meal GetMealById(int id); 
    Meal AddIngredientsToMeal(MealIngredient newMealIngredient, int mealId); 
    Meal RemoveMealIngredientByMealId(int mealId, int ingredientId); 
    Meal CreateNewMeal(Meal newMeal); 
    Meal DeleteMealById(int id); 
}