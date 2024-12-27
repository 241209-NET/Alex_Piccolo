namespace CalorieTracker.API.Model; 

public class Ingredient
{
    public int Id { get; set; }
    
    public required string Name { get; set; }

    public int CaloriesPerGram { get; set; } = 0; 

    //Video from morning of 12/23/24 might have details on how to implement join table
}