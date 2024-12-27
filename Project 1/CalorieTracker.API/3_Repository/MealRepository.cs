using CalorieTracker.API.Data;
using CalorieTracker.API.Model;

namespace CalorieTracker.API.Repository; 

public class MealRepository : IMealRepository
{
    private readonly CalorieTrackerContext _calorieTrackerContext; 

    public MealRepository(CalorieTrackerContext calorieTrackerContext) => _calorieTrackerContext = calorieTrackerContext; 

    //Start writing Repo CRUD operations

    //Create a new Meal
     public Meal CreateNewMeal(Meal newMeal)
    {
        _calorieTrackerContext.Add(newMeal); 
        _calorieTrackerContext.SaveChanges(); 

        //make sure this is returning the correct id or other changes
        return newMeal; 
    }

    //Add a MealIngredient to the ingredient list of a Meal
    public Meal AddIngredientsToMeal(MealIngredient newMealIngredient, int mealId)
    {
        var theMeal = GetMealById(mealId); 
        theMeal.IngredientList.Add(newMealIngredient); 
        _calorieTrackerContext.SaveChanges(); 

        return GetMealById(mealId); 
    }

    //Get Meal By Id
    public Meal GetMealById(int id)
    {
        return _calorieTrackerContext.Meals.Find(id); 
    }

}