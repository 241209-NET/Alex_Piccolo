namespace CalorieTracker.API.Model; 

public class MealIngredient
{
    public int Id { get; set; }

    public Ingredient IngredientWithQuantity{ get; set; }

    public int Quantity { get; set; }

}