using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    /// <summary>
    /// This class represents a printer which prints into a file in the local file system.
    /// </summary>
    public class FilePrinter: IPrinter
    {
        private string _path;

        /// <summary>
        /// The path of the file in which the recipe data will be written.
        /// </summary>
        public string Path {
            get => _path ?? "Recipe.txt";
            set => _path = value;
        }

        public FilePrinter(string path = null)
        {
            this.Path = path;
        }

        void IPrinter.PrintRecipe(string recipeText)
        {
            File.WriteAllText(Path, recipeText);
        }
    }
}