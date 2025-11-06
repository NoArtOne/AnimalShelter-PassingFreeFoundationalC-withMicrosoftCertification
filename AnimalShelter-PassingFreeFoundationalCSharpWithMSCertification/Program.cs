using ConsoleView.Views;
using ConsoleView.ViewsInput;
using Models;
using Service;

bool exit = false;

while (!exit)
{
    var _storage = new AnimalStorage();
    new ViewWelcomeHeader().Show();
    string userSelectedOption = new ViewValidInputMainMenu("" +
        "").Show();

    switch (userSelectedOption)
    {
        case "1": // Вывод информации о всех животных в приюте
            new ViewSelectUserOption(userSelectedOption).Show();
            IEnumerable<Animal> existAnimals = _storage.GetAllAnimals();
            foreach (Animal animal in existAnimals) new ViewAllAnimalsInfo().Show(animal);
            new ViewInputAnyKeyToContinue().Show();
            break;

        case "2": // Добавление нового животного в массив _animals
            new ViewSelectUserOption(userSelectedOption).Show();
            int currentNumberOfAnimalsInShelter = _storage.CurrentNumberOfAnimals();
            if (currentNumberOfAnimalsInShelter >= AnimalStorage.MaxPets)
            {
                new ViewReachedLimitPetsInShelter().Show();
                new ViewInputAnyKeyToContinue().Show();
                break;
            }

            new ViewNotReachedLimitPetsInShelter(
                currentNumberOfAnimalsInShelter,
                AnimalStorage.MaxPets).Show();

            bool exitOptionTwo = false;
            while (!exitOptionTwo)
            {
                var userSelectedOptionTwo = new ViewInputValidInput().Show();
                switch (userSelectedOptionTwo)
                {
                    case "y":
                        if (currentNumberOfAnimalsInShelter >= AnimalStorage.MaxPets)
                        {
                            new ViewReachedLimitPetsInShelter().Show();
                            new ViewInputAnyKeyToContinue().Show();
                            break;
                        }
                        new ViewSelectOptionInDevelopment(userSelectedOption).Show();
                        exitOptionTwo = true;
                        break;

                    case "n":
                        exitOptionTwo = true;
                        break;

                    default:
                        new ViewUserEnteredInvalidInput().Show();
                        break;

                }
            }
            break;


        //            switch (readResultFromOptionTwo)
        //            {
        //                case "y":
        //                    petCount += 1;
        //                    if (petCount >= AnimalFactory.MaxPets)
        //                    {
        //                        Console.WriteLine($"{root.GetProperty("ViewReachedLimitPetsInShelter").GetString()}");
        //                        break;
        //                    }
        //                    else
        //                    {
        //                        Console.WriteLine("Enter 'dog' or 'cat' to begin a new entry");
        //                        string selectedAnimalSpecies = RepeatedPrintText.ValidateForEmptyReadInput(root);
        //                        if (selectedAnimalSpecies == null) continue;

        //                        Console.WriteLine("Enter 'dog' or 'cat' to begin a new entry");
        //                        string selectedAnimalSpecies = RepeatedPrintText.ValidateForEmptyReadInput(root);
        //                        if (selectedAnimalSpecies == null) continue;

        //                        Console.WriteLine("Enter 'dog' or 'cat' to begin a new entry");
        //                        string selectedAnimalSpecies = RepeatedPrintText.ValidateForEmptyReadInput(root);
        //                        if (selectedAnimalSpecies == null) continue;


        //                        Console.WriteLine("Enter 'dog' or 'cat' to begin a new entry");
        //                        string selectedAnimalSpecies = RepeatedPrintText.ValidateForEmptyReadInput(root);
        //                        if (selectedAnimalSpecies == null) continue;

        //                        Console.WriteLine("Enter 'dog' or 'cat' to begin a new entry");
        //                        string selectedAnimalSpecies = RepeatedPrintText.ValidateForEmptyReadInput(root);
        //                        if (selectedAnimalSpecies == null) continue;

        //                    }
        //                    break;

        //                case "n":
        //                    exitOptionTwo = true;
        //                    break;

        //                default:
        //                    Console.WriteLine($"{root.GetProperty("InvalidInput").GetString()}");
        //                    break;
        //            }
        //        }

        case "3":
            new ViewSelectOptionInDevelopment(userSelectedOption).Show(); break;
        case "4":
            new ViewSelectOptionInDevelopment(userSelectedOption).Show(); break;
        case "5":
            new ViewSelectOptionInDevelopment(userSelectedOption).Show(); break;
        case "6":
            new ViewSelectOptionInDevelopment(userSelectedOption).Show(); break;
        case "7":
            new ViewSelectOptionInDevelopment(userSelectedOption).Show(); break;
        case "8":
            new ViewSelectOptionInDevelopment(userSelectedOption).Show(); break;
        case "exit":
            exit = true;
            break;
        default:
            new ViewUserEnteredInvalidInput().Show();
            break;
    }
}
