using System.IO;

namespace Full_GRASP_And_SOLID
{
    public class FilePrinter : IPrinter
    {
        public void PrintRecipe(IRecipePrinter recipePrint)
        {
            File.WriteAllText("Recipe.txt", recipePrint.GetTextToPrint());
        }
    }
}