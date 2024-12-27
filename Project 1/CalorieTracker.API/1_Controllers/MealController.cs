using CalorieTracker.API.Model;
using CalorieTracker.API.Service;
using Microsoft.AspNetCore.Mvc;

namespace CalorieTracker.API.Controller; 

[Route("api/[controller]")]
[ApiController]
public class MealController : ControllerBase
{
    private readonly IMealService _mealService; 
    private readonly IIngredientService _ingredientService; 

    public MealController(IMealService mealService, IIngredientService ingredientService)
    {
        _mealService = mealService; 
        _ingredientService = ingredientService; 
    }

    //Add new meal
    [HttpPost]
    public IActionResult CreateNewMeal(Meal newMeal)
    {
        var addMeal = _mealService.CreateNewMeal(newMeal); 
        return Ok(addMeal); 
        //should add options other than Ok for failure? 
    }


    //Add MealIngredients to meal
    [HttpPut("{mealId}/{ingredientId}/{quantity}")]
    public IActionResult AddIngredientsToMeal(int mealId, int ingredientId, int quantity)
    {
        //set values of newMealIngredient
        var newMealIngredient = new MealIngredient(); 
        var newIngredient = _ingredientService.GetIngredientById(ingredientId); 
        newMealIngredient.IngredientWithQuantity = newIngredient; 
        newMealIngredient.Quantity = quantity; 

        //add newMealIngredient to list of MealIngredients in meal
        //so call AddIngredientsToMeal in mealService
        var updatedMeal = _mealService.AddIngredientsToMeal(newMealIngredient, mealId); 
        return Ok(updatedMeal); 

    }
    

    //Delete what MealIngredients are in the meal

    //See what MealIngredients are in the meal

    //retrieve calories of all MealIngredients in the meal

    //delete meals
}