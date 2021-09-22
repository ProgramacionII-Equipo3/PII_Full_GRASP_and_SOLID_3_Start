using System;

namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter: IPrinter
    {
        void IPrinter.PrintRecipe(string recipeText)
        {
            Console.WriteLine(recipeText);
        }
    }
}