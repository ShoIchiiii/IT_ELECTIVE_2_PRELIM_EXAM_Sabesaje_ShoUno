using System;
using IT_ELECTIVE_2_PRELIM_EXAM.Interfaces;

namespace IT_ELECTIVE_2_PRELIM_EXAM.Models;

// EXERCISE 7 & 9: Inherit + implement interface
public class MealRecipe : RecipeBase, IRecipeSearchable
{
    public string Category { get; set; }
    public string Area { get; set; }

    public MealRecipe() : base()
    {
        Category = "";
        Area = "";
    }

    public MealRecipe(string title, int prepTime, string difficulty)
        : base(title, prepTime, difficulty)
    {
        Category = "";
        Area = "";
    }

    // New constructor for tests
    public MealRecipe(string title, int prepTime, string difficulty, string category, string area)
        : base(title, prepTime, difficulty)
    {
        Category = category;
        Area = area;
    }

    // EXERCISE 7: Override method
    public override string GetRecipeInfo()
    {
        return $"{base.GetRecipeInfo()} | Category: {Category} | Area: {Area}";
    }

    // EXERCISE 9: Interface implementation
    public string SearchCriteria => Title;

    public bool MatchesSearch(string searchTerm)
    {
        return Title.Contains(searchTerm, StringComparison.OrdinalIgnoreCase);
    }
}