using CalorieTracker.API.Data;
using CalorieTracker.API.Model;
using Microsoft.VisualBasic;

namespace CalorieTracker.API.Repository; 

public class IngredientRepository : IIngredientRepository
{
    private readonly CalorieTrackerContext _calorieTrackerContext; 

    public IngredientRepository(CalorieTrackerContext calorieTrackerContext) => _calorieTrackerContext = calorieTrackerContext; 

    //Start writing Repo CRUD operations

    //Does this work?? 
    public IEnumerable<Ingredient> GetAllIngredients()
    {
        return _calorieTrackerContext.Ingredients.ToList(); 
    }

    public IEnumerable<Ingredient> CreateNewIngredient(Ingredient newIngredient)
    {
        _calorieTrackerContext.Add(newIngredient); 
        _calorieTrackerContext.SaveChanges(); 

        //return find new ingredient in db? 
        return GetIngredientByName(newIngredient.Name); 
    }

    public Ingredient UpdateIngredientById(Ingredient updateIngredient)
    {
        var existingIngredient = GetIngredientById(updateIngredient.Id); 

        //Does this work? Or needs to be re-added or something? 
        //When you get it to work, add update ingredient by name
        existingIngredient.Name = updateIngredient.Name; 
        existingIngredient.CaloriesPerGram = updateIngredient.CaloriesPerGram; 
        _calorieTrackerContext.SaveChanges(); 

        return GetIngredientById(updateIngredient.Id); 
    }

    public Ingredient GetIngredientById(int id)
    {
        return _calorieTrackerContext.Ingredients.Find(id); 
    }

    public IEnumerable<Ingredient> GetIngredientByName(string name)
    {
        //update away from IEnumerable if I want name to be unique? 
        //Try the Find version of this? 
        return _calorieTrackerContext.Ingredients.Where(ing => ing.Name.Contains(name)).ToList(); 
    }

    //Delete Ingredient
    public Ingredient DeleteIngredientById(int id)
    {
        //need null check for getingredientbyid? 
        var deleteIngredient = GetIngredientById(id); 
        _calorieTrackerContext.Ingredients.Remove(deleteIngredient); 
        _calorieTrackerContext.SaveChanges(); 
        return deleteIngredient; //does this return the info it held, or null? 
    }

}