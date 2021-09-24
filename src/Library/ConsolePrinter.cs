using System;

namespace Full_GRASP_And_SOLID.Library
{
    /// <summary>
    /// This class represents a printer which prints into the console.
    /// </summary>
    public class ConsolePrinter: IPrinter
    {
        void IPrinter.PrintRecipe(string recipeText)
        {
            Console.WriteLine(recipeText);
        }
    }
}