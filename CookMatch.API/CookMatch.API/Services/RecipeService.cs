using CookMatch.API.Core.Abstractions.Repositories;
using CookMatch.API.Core.Abstractions.Services;
using CookMatch.API.Core.Models;
using Microsoft.AspNetCore.Identity;

namespace CookMatch.API.Services
{
    public class RecipeService : IRecipeService
    {
        private readonly IRecipeRepository recipeRepository;

        public RecipeService(IRecipeRepository recipeRepository)
        {
            this.recipeRepository = recipeRepository;
        }

        public async Task<List<Recipe>> GetRecipes() // добавить логику фильтров запроса
        {
            return await recipeRepository.Get();
        }

        public async Task<Guid> CreateRecipe(Recipe recipe)
        {
            return await recipeRepository.Create(recipe);
        }

        public async Task<Guid> UpdateRecipe(Recipe recipe)
        {
            return await recipeRepository.Update(recipe);
        }

        public async Task<Guid> DeleteRecipe(Guid id)
        {
            return await recipeRepository.Delete(id);
        }
    }
}
