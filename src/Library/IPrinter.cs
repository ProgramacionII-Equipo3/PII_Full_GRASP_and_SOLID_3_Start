using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    /// <summary>
    /// This interface represents the responsibility of printing a recipe to a form of text output,
    /// which depends on the implementation.
    /// </summary>
    public interface IPrinter
    {
        public void PrintRecipe(string recipeText);
    }
}