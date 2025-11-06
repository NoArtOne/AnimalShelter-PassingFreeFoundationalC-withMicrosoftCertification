using ConsoleView.Views;

namespace ConsoleView.ViewsInput;

public class ViewInputValidInput : ViewBase
{

    public string TextToOutput { get; }
    /// <summary>
    /// Если выводить ничего
    /// </summary>
    public ViewInputValidInput()
    {
        TextToOutput = "";
    }
    /// <summary>
    /// Если есть что выводить при ошибке пользователю :)
    /// </summary>
    /// <param name="textToOutput"></param>
    public ViewInputValidInput(string textToOutput)
    {
        TextToOutput = textToOutput;
    }

    public string Show()
    {
        string? userInput = null;
        while (userInput == null)
        {
            if (TextToOutput != "") Console.WriteLine(TextToOutput);
            userInput = Console.ReadLine();
            if (string.IsNullOrEmpty(userInput)) new ViewEmptyInput().Show();
            else userInput = userInput.Trim().ToLower();
        }
        return userInput;
    }
}
