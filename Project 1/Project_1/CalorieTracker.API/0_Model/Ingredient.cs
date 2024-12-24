namespace CalorieTracker.API.Model; 

public class Ingredient
{
    public int Id { get; set; }
    public required string Name { get; set; }

    //Video from morning of 12/23/24 might have details on how to implement join table
}