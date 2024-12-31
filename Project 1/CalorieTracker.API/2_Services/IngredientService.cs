using CalorieTracker.API.Model;
using CalorieTracker.API.Repository;

namespace CalorieTracker.API.Service; 

public class IngredientService : IIngredientService
{
    public readonly IIngredientRepository _ingredientRepository; 
    
    public IngredientService(IIngredientRepository ingredientRepository) => _ingredientRepository = ingredientRepository; 

    //Note: These methods are where you perform any necessary logic, eg input data validation

    public IEnumerable<Ingredient> GetAllIngredients()
    {
        return _ingredientRepository.GetAllIngredients(); 
    }

     public IEnumerable<Ingredient> CreateNewIngredient(Ingredient newIngredient)
     {
        //ensure name is unique? Or use tags to accomplish this? 
        return _ingredientRepository.CreateNewIngredient(newIngredient); 
     }

     public Ingredient UpdateIngredientById(Ingredient updateIngredient)
     {
        //service layer should retrieve udated ingredient? Or keep in repo layer? 
        return _ingredientRepository.UpdateIngredientById(updateIngredient); 
     }

     public Ingredient GetIngredientById(int id)
     {
        //Add logic to ensure id is not null
        return _ingredientRepository.GetIngredientById(id); 
     }

     public IEnumerable<Ingredient> GetIngredientByName(string name)
     {
        //Add logic to ensure name is not null
        return _ingredientRepository.GetIngredientByName(name); 
     }

      //Delete Ingredient
      public Ingredient DeleteIngredientById(int id)
      {
         return _ingredientRepository.DeleteIngredientById(id); 
      }

    //Note: Only the services should have the logic! They are the only thing we test! 
    //if you write utilities you need to test those too
    //need to test 20% of logic
}