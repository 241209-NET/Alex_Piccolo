using CalorieTracker.API.Model;
using CalorieTracker.API.Service;
using Microsoft.AspNetCore.Mvc;

namespace CalorieTracker.API.Controller; 

[Route("api/[controller]")]
[ApiController]
public class IngredientController : ControllerBase
{
    private readonly IIngredientService _ingredientService; 

    public IngredientController(IIngredientService ingredientService) => _ingredientService = ingredientService; 


    //retrieve list of all ingredients
    [HttpGet]
    public IActionResult GetAllIngredients()
    {
        var ingredientList = _ingredientService.GetAllIngredients(); 
        return Ok(ingredientList); 
    }

    //Add new ingredient
    [HttpPost]
    public IActionResult CreateNewIngredient(Ingredient newIngredient)
    {
        var ing = _ingredientService.CreateNewIngredient(newIngredient); 
        return Ok(ing); 
    }

    //retrieve single ingredient info by id
    [HttpGet("{id}")]
    public IActionResult GetIngredientById(int id)
    {
        var findIngredient = _ingredientService.GetIngredientById(id); 
        //if(findIngredient is null) return NotFound(); 
        //but null check should be in service layer? 
        return Ok(findIngredient); 
    }


    //retrieve single ingredient by name
    [HttpGet("name/{name}")]//Does this work? 
     public IActionResult GetIngredientByName(string name)
    {
        var findIngredient = _ingredientService.GetIngredientByName(name); 
        //if(findIngredient is null) return NotFound(); 
        //but null check should be in service layer? 
        return Ok(findIngredient); 
    }

    //edit existing ingredient
    [HttpPut]
    public IActionResult UpdatePet(Ingredient updateIngredient)
    {
        var updatedIngredient = _ingredientService.UpdateIngredientById(updateIngredient); 
        return Ok(updatedIngredient); 
    }

    //delete ingredient by id
    //Need to add related methods to service & repo

    [HttpDelete("{id}")]
    public IActionResult DeleteIngredient(int id)
    {
        //test that this works
        var deleteIngredient = _ingredientService.DeleteIngredientById(id); 
        return Ok(deleteIngredient); 
    }





}