using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleView;
using ConsoleView.Views;
using ENUM;
using Models;

namespace ConsoleView.ViewsInput;

public class ViewCaseValidAddAnimal : ViewBase
{
    public ViewCaseValidAddAnimal()
    {
    }

    /// <summary>
    /// Выводит пункты для заполнения для добавления нового животного
    /// </summary>

    public Animal Show()
    {
        bool processOfAddAnimal = false;
        int animalAge = 0;
        string animalNickname = "";
        string animalPersonalityDescription = "";
        string animalPhysicalDescription = "";
        AnimalSpecies animalSpecies;

        while (processOfAddAnimal == false)
        {
            string enteredTextStepOne = new ViewInputValidInput(GetString("EnterDogOrCat")).Show();
            Console.WriteLine(enteredTextStepOne);
            switch (enteredTextStepOne)
            {
                case "cat":
                    animalSpecies = AnimalSpecies.Cat;
                    break;
                case "dog":
                    animalSpecies = AnimalSpecies.Dog;
                    break;
                default:
                    Console.WriteLine(GetString("InvalidInput"));
                    continue;
            }


        }
        return new Animal
        {
            AnimalAge = 2,
            AnimalNickname = "lola",
            AnimalPersonalityDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.",
            AnimalPhysicalDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.",
            AnimalSpecies = AnimalSpecies.Dog,
            AnimalID = Guid.NewGuid().ToString("N")
        };

    }
}
