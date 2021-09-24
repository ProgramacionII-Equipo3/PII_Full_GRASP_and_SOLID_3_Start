using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    /// <summary>
    /// This interface represents the responsibility of printing a recipe to a form of text output,
    /// which depends on the implementation.
    /// This allows to make the process of printing a recipe a polymorphic operation.
    /// </summary>
    public interface IPrinter
    {
        /// <summary>
        /// Prints the text of a recipe.
        /// The text is received as a parameter instead of the recipe itself because of the SRP principle,
        /// since the printer only cares about printing the text, so it doesn't need access to the recipe.
        /// Also, it ensures that it can't change the recipe the same way the implementation of TimeMachinePrinter could.
        /// </summary>
        /// <param name="recipeText">The text to print.</param>
        public void PrintRecipe(string recipeText);
    }
}