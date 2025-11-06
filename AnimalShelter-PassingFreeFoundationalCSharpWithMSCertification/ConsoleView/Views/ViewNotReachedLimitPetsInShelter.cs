using System.Diagnostics.CodeAnalysis;

namespace ConsoleView.Views;

public class ViewNotReachedLimitPetsInShelter : View
{
    private readonly int _maxPets;
    private readonly int _petCount;

    public ViewNotReachedLimitPetsInShelter(int petCount, int maxPets)
    {
        _petCount = petCount;
        _maxPets = maxPets;
    }

    public new void Show()
    {
        string message = string.Format(GetString("NotReachedLimitPetsInShelter"), _petCount, _maxPets - _petCount);
        Console.WriteLine(message);
    }
}
