using CookMatch.API.Core.Abstractions.Repositories;
using CookMatch.API.Core.Abstractions.Services;
using CookMatch.API.DataAccess;
using CookMatch.API.DataAccess.Repositories;
using CookMatch.API.Endpoints;
using CookMatch.API.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddEndpointsApiExplorer();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IRecipeRepository, RecipeRepository>();
builder.Services.AddScoped<IRecipeService, RecipeService>();
builder.Services.AddScoped<IIngredientRepository, IngredientRepository>();
builder.Services.AddScoped<IIngredientService, IngredientService>();


builder.Services.AddDbContext<CookMatchDbContext>(
    options =>
    {
        options.UseSqlServer(builder.Configuration.GetConnectionString(nameof(CookMatchDbContext)));
    });

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapRecipesEndpoits();

app.Run();
