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

    //get all meals
    [HttpGet]
    public IActionResult GetAllMeals()
    {
        var mealList = _mealService.GetAllMeals(); 
        return Ok(mealList); 
    }

    //get meal by id
    [HttpGet("{id}")]
    public IActionResult GetMealById(int id)
    {
        var meal = _mealService.GetMealById(id); 
        return Ok(meal); 
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
    [HttpPut("{mealId}/{ingredientId}")]
    public IActionResult RemoveMealIngredientById(int mealId, int ingredientId)
    {
        var updateMeal = _mealService.RemoveMealIngredientById(mealId, ingredientId); 
        return Ok(updateMeal); //does it return the meal showing the ingredient has been removed? 
    }


    //See what MealIngredients are in the meal
    [HttpGet("ingredients/{mealId}")]
    public IActionResult ListAllIngredients(int mealId)
    {
        var ingredientList = _mealService.ListAllIngredients(mealId); 
        return Ok(ingredientList); 
    }

    //retrieve calories of all MealIngredients in the meal
    [HttpGet("total/{id}")]
    public IActionResult GetMealTotalCalories(int id)
    {
        double totalCal = _mealService.GetMealTotalCalories(id); 
        return Ok(totalCal); 
    }

    //delete meals
     [HttpDelete("{id}")]
    public IActionResult DeleteMeal(int id)
    {
        //test that this works
        var deleteMeal = _mealService.DeleteMealById(id); 
        return Ok(deleteMeal); 
    }
}