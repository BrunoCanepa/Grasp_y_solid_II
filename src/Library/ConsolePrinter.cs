using System;
namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter
    {
        public void PrintRecipe(Recipe recipe)
    {
        Console.WriteLine(recipe.GetRecipeText());
    }
    }
}