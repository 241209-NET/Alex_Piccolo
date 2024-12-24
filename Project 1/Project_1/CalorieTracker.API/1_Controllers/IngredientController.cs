using CalorieTracker.API.Service;
using Microsoft.AspNetCore.Mvc;

namespace CalorieTracker.API.Controller; 

[Route("api/[controller]")]
[ApiController]
public class IngredientController : ControllerBase
{
    private readonly IIngredientService _ingredientService; 

    public IngredientController(IIngredientService ingredientService) => _ingredientService = ingredientService; 
}