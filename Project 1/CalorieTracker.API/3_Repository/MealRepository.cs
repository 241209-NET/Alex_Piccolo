using CalorieTracker.API.Data;
using CalorieTracker.API.Model;

namespace CalorieTracker.API.Repository; 

public class MealRepository : IMealRepository
{
    private readonly CalorieTrackerContext _calorieTrackerContext; 

    public MealRepository(CalorieTrackerContext calorieTrackerContext) => _calorieTrackerContext = calorieTrackerContext; 

    //Start writing Repo CRUD operations

    //Get all meals
     public IEnumerable<Meal> GetAllMeals()
    {
        return _calorieTrackerContext.Meals.ToList(); 
    }


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

    //List ingredients by MealId
        //just get the meal and retrieve ingredients in another layer? 

    //Delete Meal
    public Meal DeleteMealById(int id)
    {
        //need null check for getMealbyid? 
        var deleteMeal = GetMealById(id); 
        _calorieTrackerContext.Meals.Remove(deleteMeal); 
        _calorieTrackerContext.SaveChanges(); 
        return deleteMeal; //does this return the info it held, or null? 
    }

    //Remove MealIngredient from the meal
    public Meal RemoveMealIngredientByMealId(int mealId, int ingredientId)
    {

        var updateMeal = GetMealById(mealId); 
        foreach(MealIngredient ing in updateMeal.IngredientList)
        {
            if(ing.IngredientWithQuantity.Id == ingredientId)
            {
                updateMeal.IngredientList.Remove(ing); 
            }
        }

        return updateMeal; 

    }

    //Get Meal By Id
    public Meal GetMealById(int id)
    {
        return _calorieTrackerContext.Meals.Find(id); 
    }

}