using System;

namespace Full_GRASP_And_SOLID
{
    public class ConsolePrinter : IPrinter
    {
        public void PrintRecipe(IRecipePrinter recipePrint)
        {
            Console.WriteLine(recipePrint.GetTextToPrint());
        }
    }
}