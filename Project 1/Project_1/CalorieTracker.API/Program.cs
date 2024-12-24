using CalorieTracker.API.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

//Add dbcontext with connection string
builder.Services.AddDbContext<CalorieTrackerContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString(""))); 

//Add service dependencies

//Add repo dependencies

//Add controllers
builder.Services.AddControllers(); 
// -- to do: can add anti-cycling code here, see example project code


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
//Map controllers
//--- to do, review example project code

app.Run();
