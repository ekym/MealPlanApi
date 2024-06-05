using Microsoft.AspNetCore.Mvc;
using MealPlanApi.DTO;

namespace MealPlanApi.Controllers;

[ApiController]
[Route("[controller]")]
public class MealController : ControllerBase
{
    private static readonly List<IngredientDTO> Ingredients = new List<IngredientDTO>
    {
        new IngredientDTO("Carotte", 1, IngredientUnit.Count),
        new IngredientDTO("Tomate", 1, IngredientUnit.Count),
        new IngredientDTO("Poivron", 1, IngredientUnit.Count),
        new IngredientDTO("Pates", 500, IngredientUnit.Gram),
        new IngredientDTO("Haché porc/boeuf", 500, IngredientUnit.Gram),
        new IngredientDTO("Purée de tomate", 500, IngredientUnit.MiliLitre),
    };

    private static readonly List<RecipeStepDTO> Steps = new List<RecipeStepDTO>
    {
        new RecipeStepDTO("Couper légumes"),
        new RecipeStepDTO("Cuire légumes"),
        new RecipeStepDTO("Cuire viande"),
        new RecipeStepDTO("Mélanger viande, légumes, purée de tomate et cuire le tout"),
        new RecipeStepDTO("Cuire pâtes"),
        new RecipeStepDTO("Mélanger tout")
    };

    private static readonly List<RecipeDTO> Recipes = new List<RecipeDTO>
    {
        new RecipeDTO("Pâtes bolognaise", Ingredients, Steps)
    };

    private static readonly List<MealDTO> Meals = new List<MealDTO>
    {
        new MealDTO(Recipes[0], 2, DayOfWeek.Monday, MealOfDay.Dinner),
        new MealDTO(Recipes[0], 4, DayOfWeek.Friday, MealOfDay.Lunch)
    };

    private readonly ILogger<MealController> _logger;

    public MealController(ILogger<MealController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<MealDTO> Get()
    {
        return Meals;
    }
}
