namespace MealPlanApi.DTO;

public record MealDTO(RecipeDTO Recipe, int peopleCount, DayOfWeek DayOfWeek, MealOfDay MealOfDay);
