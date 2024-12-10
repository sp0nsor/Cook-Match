namespace CookMatch.API.Contacts
{
    public record RecipeRequest(
        string Name,
        List<IngredientRequest> Ingredients);
}
