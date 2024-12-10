using CookMatch.API.Core.Models;

namespace CookMatch.API.Core.Abstractions.Repositories
{
    public interface IRecipeRepository
    {
        Task<Guid> Create(Recipe recipe);
        Task<Guid> Delete(Guid id);
        Task<List<Recipe>> Get();
        Task<Guid> Update(Recipe recipe);
    }
}