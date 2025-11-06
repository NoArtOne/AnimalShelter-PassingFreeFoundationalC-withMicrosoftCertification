using ConsoleView.ViewsInput;
using ConsoleView.Views;
using System.Text;

namespace ConsoleView.ViewsInput;
/// <summary>
/// Необходим чтобы пользователь успел ознакомиться с контектом
/// </summary>
public class ViewInputAnyKeyToContinue() : ViewInputValidInput
{
    public new string? Show()
    {
        Console.WriteLine($"{GetString("InputAnyKeyToContinue")}");
        Console.ReadKey();
        return null;
    }
}