using System.Diagnostics.CodeAnalysis;

namespace ConsoleView.Views;

public class ViewReachedLimitPetsInShelter : View
{
    public new void Show() => Console.WriteLine("{0}",
        GetString("ReachedLimitPetsInShelter"));
}
