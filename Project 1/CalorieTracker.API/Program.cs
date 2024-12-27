using CalorieTracker.API.Data;
using CalorieTracker.API.Repository;
using CalorieTracker.API.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Add dbcontext with connection string
builder.Services.AddDbContext<CalorieTrackerContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("CalorieTracker"))); 

//Add service dependencies
builder.Services.AddScoped<IIngredientService, IngredientService>();
builder.Services.AddScoped<IMealService, MealService>();

//Add repo dependencies
builder.Services.AddScoped<IIngredientRepository, IngredientRepository>();
builder.Services.AddScoped<IMealRepository, MealRepository>();

//Add controllers
builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles;
    });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers(); 

app.Run();
