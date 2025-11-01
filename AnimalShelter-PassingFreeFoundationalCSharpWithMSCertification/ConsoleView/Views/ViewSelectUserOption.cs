using ConsoleView.Views;
using ConsoleView.ViewsInput;
using System.Text;

namespace ConsoleView.Views;

public class ViewSelectUserOption(string _text) : View
{
    public new void Show()
    {
        Console.WriteLine($"{GetString("SelectedOption")}{_text}.");
    }}
