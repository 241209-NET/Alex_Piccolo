using CalorieTracker.API.Model;
using Microsoft.EntityFrameworkCore;

namespace CalorieTracker.API.Data; 

public class CalorieTrackerContext : DbContext
{
    public CalorieTrackerContext(){}
    public CalorieTrackerContext(DbContextOptions<CalorieTrackerContext> options) : base(options){}

    public DbSet<Ingredient> Ingredients { get; set; }
    public DbSet<Meal> Meals { get; set; }
    public DbSet<MealIngredient> MealIngredients { get; set; } //check that I am actually using this at end
}