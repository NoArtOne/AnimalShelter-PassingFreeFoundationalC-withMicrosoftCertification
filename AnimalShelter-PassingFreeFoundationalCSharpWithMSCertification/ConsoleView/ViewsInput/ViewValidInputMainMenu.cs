using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleView;
using ConsoleView.Views;

namespace ConsoleView.ViewsInput;

public class ViewValidInputMainMenu : ViewInput
{

    public ViewValidInputMainMenu(string textToOutput) : base(textToOutput)
    {
    }

    /// <summary>
    /// Выводит пункты основного меню и валидирует что введенное значение not null && not Empty
    /// </summary>

    public new string Show()
    {
        string? userInput = null;
        while (userInput == null)
        {
            Console.WriteLine("{0}\n{1}", GetString("MenuOptions"), GetString("ExitInput"));
            if (TextToOutput != "") Console.WriteLine(TextToOutput);
            userInput = Console.ReadLine();
            Console.WriteLine("HEY");
            if (string.IsNullOrEmpty(userInput)) new ViewEmptyInput().Show();
            else userInput = userInput.Trim().ToLower();
        }
        return userInput;
    }
}
