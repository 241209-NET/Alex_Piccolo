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
}

public interface IMealService
{
    Meal GetMealById(int id); 
    Meal AddIngredientsToMeal(MealIngredient addMealIngredient, int mealId); 
    Meal CreateNewMeal(Meal newMeal); 
    //include all the operations you want to have in ther service layer
}