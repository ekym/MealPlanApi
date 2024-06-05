namespace MealPlanApi.DTO;

public record RecipeDTO(string Name, List<IngredientDTO> Ingredients, List<RecipeStepDTO> Steps);