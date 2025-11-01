namespace ConsoleView.ViewsInput;

public class ViewInput : ViewBase
{

    public string TextToOutput { get; }
    /// <summary>
    /// Если выводить ничего
    /// </summary>
    public ViewInput()
    {
        TextToOutput = "";
    }

    public ViewInput(string textToOutput)
    {
        TextToOutput = textToOutput;
    }

    public string? Show()
    {
        if (TextToOutput != "") Console.WriteLine(TextToOutput);
        string userEnteredText = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(userEnteredText)) return userEnteredText;
        return null;
    }
}
