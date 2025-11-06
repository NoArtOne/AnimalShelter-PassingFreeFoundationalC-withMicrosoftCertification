using System.Diagnostics.CodeAnalysis;

namespace ConsoleView.Views;

public class View : ViewBase
{
    private readonly string _text;
    public View(string text = "")
    {
        _text = text ?? throw new ArgumentNullException(nameof(text));
    }
    public View()
    {
        _text = "";
    }

    public void Show()
    {
        Console.WriteLine(_text);
    }
}
