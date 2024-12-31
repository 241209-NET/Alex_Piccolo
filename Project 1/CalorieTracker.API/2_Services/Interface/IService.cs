using CalorieTracker.API.Model;

namespace CalorieTracker.API.Service; 

public interface IIngredientService
{
    //include all the operations you want to have in the service layer
    IEnumerable<Ingredient> GetAllIngredients(); 
    IEnumerable<Ingredient> CreateNewIngredient(Ingredient newIngredient); 
    Ingredient UpdateIngredientById(Ingredient updateIngredient); 
     public Ingredient GetIngredientById(int id); 
     IEnumerable<Ingredient> GetIngredientByName(string name); 

     Ingredient DeleteIngredientById(int id); 
}

public interface IMealService
{
    IEnumerable<Meal> GetAllMeals(); 
    Meal GetMealById(int id); 
    IEnumerable<MealIngredient> ListAllIngredients(int mealId);
    Meal AddIngredientsToMeal(MealIngredient addMealIngredient, int mealId); 
    Meal RemoveMealIngredientById(int mealId, int ingredientId);    Meal CreateNewMeal(Meal newMeal); 
    double GetMealTotalCalories(int mealId); 
    Meal DeleteMealById(int id); 

    //include all the operations you want to have in the service layer
}