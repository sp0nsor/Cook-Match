namespace CookMatch.API.Contacts
{
    public record RecipeResponse(
        string Name,
        List<IngredientResponse> Ingredients);
}
