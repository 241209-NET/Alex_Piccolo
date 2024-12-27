namespace CalorieTracker.API.Model; 

public class Meal
{
    public int Id { get; set; }

    public required string Name { get; set; }

    public List<MealIngredient> IngredientList {get; set; } = []; 

}