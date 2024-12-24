using CalorieTracker.API.Model;
using Microsoft.EntityFrameworkCore;

namespace CalorieTracker.API.Data; 

public class CalorieTrackerContext : DbContext
{
    public CalorieTrackerContext(){}
    public CalorieTrackerContext(DbContextOptions<CalorieTrackerContext> options) : base(options){}

    public DbSet<Ingredient> Ingredients { get; set; }
}