using ConsoleView.Views;
using ConsoleView.ViewsInput;


bool exit = false;

while (!exit)
{
    new ViewWelcomeHeader().Show();

    var userSelectedOption = new ViewInput().Show();
    if (userSelectedOption == null) continue;


    //string headInputKey.Show();
    //if (headInputKey.Show() == null) continue;

    //RepeatedPrintText printer = new();

    //switch (readResult)
    //{
    //    case "1": // Вывод информации о всех животных в приюте
    //        printer.PrintUserOption(root, readResult);
    //        for (int i = 0; i < AnimalFactory.MaxPets; i++)
    //        {
    //            if (_animals[i].AnimalID != null)
    //            {
    //                Console.WriteLine(
    //                    "ID: {0} \nNickname: {1} \nPersonality: {2} \n" +
    //                    "Physical: {3} \nAge: {4} \nSpecies: {5}\n",
    //                    _animals[i].AnimalID,
    //                    _animals[i].AnimalNickname,
    //                    _animals[i].AnimalPersonalityDescription,
    //                    _animals[i].AnimalPhysicalDescription,
    //                    _animals[i].AnimalAge,
    //                    _animals[i].AnimalSpecies
    //                    );
    //            }
    //        }
    //        printer.PrintInputAnyToContinue(root);
    //        break;

    //    case "2": // Добавление нового животного в массив _animals
    //        printer.PrintUserOption(root, readResult);
    //        int petCount = 0;
    //        for (int i = 0; i < AnimalFactory.MaxPets; i++)
    //        {
    //            if (_animals[i].AnimalID != null)
    //            {
    //                petCount += 1;
    //            }
    //        }
    //        if (petCount >= AnimalFactory.MaxPets)
    //        {
    //            Console.WriteLine($"{root.GetProperty("ReachedLimitPetsInShelter").GetString()}");
    //            printer.PrintInputAnyToContinue(root);
    //            break;
    //        }
    //        if (petCount < AnimalFactory.MaxPets) // поправить! Смотри выше
    //        {
    //            bool exitOptionTwo = false;
    //            while (petCount < AnimalFactory.MaxPets && exitOptionTwo == false)
    //            {
    //                Console.WriteLine($"We currently have {petCount} pets that need homes. " +
    //               $"We can manage {(AnimalFactory.MaxPets - petCount)} more.");
    //                Console.WriteLine("Do you want to enter info for another pet (y/n)");

    //                string readResultFromOptionTwo = RepeatedPrintText.ValidateForEmptyReadInput(root);
    //                if (readResultFromOptionTwo == null) continue;

    //                switch (readResultFromOptionTwo)
    //                {
    //                    case "y":
    //                        petCount += 1;
    //                        if (petCount >= AnimalFactory.MaxPets) { 
    //                            Console.WriteLine($"{root.GetProperty("ReachedLimitPetsInShelter").GetString()}");
    //                            break;
    //                        }
    //                        else
    //                        {
    //                            Console.WriteLine("Enter 'dog' or 'cat' to begin a new entry");
    //                            string selectedAnimalSpecies = RepeatedPrintText.ValidateForEmptyReadInput(root);
    //                            if (selectedAnimalSpecies == null) continue;

    //                            Console.WriteLine("Enter 'dog' or 'cat' to begin a new entry");
    //                            string selectedAnimalSpecies = RepeatedPrintText.ValidateForEmptyReadInput(root);
    //                            if (selectedAnimalSpecies == null) continue;

    //                            Console.WriteLine("Enter 'dog' or 'cat' to begin a new entry");
    //                            string selectedAnimalSpecies = RepeatedPrintText.ValidateForEmptyReadInput(root);
    //                            if (selectedAnimalSpecies == null) continue;


    //                            Console.WriteLine("Enter 'dog' or 'cat' to begin a new entry");
    //                            string selectedAnimalSpecies = RepeatedPrintText.ValidateForEmptyReadInput(root);
    //                            if (selectedAnimalSpecies == null) continue;

    //                            Console.WriteLine("Enter 'dog' or 'cat' to begin a new entry");
    //                            string selectedAnimalSpecies = RepeatedPrintText.ValidateForEmptyReadInput(root);
    //                            if (selectedAnimalSpecies == null) continue;

    //                        }
    //                            break;

    //                    case "n":
    //                        exitOptionTwo = true;
    //                        break;

    //                    default:
    //                        Console.WriteLine($"{root.GetProperty("InvalidInput").GetString()}");
    //                        break;
    //                }
    //            }

    //        }
    //        else
    //        {
    //            Console.WriteLine($"{root.GetProperty("ReachedLimitPetsInShelter").GetString()}"); 
    //            printer.PrintInputAnyToContinue(root);
    //        }
    //        break;

    //    case "3":
    //        printer.PrintOptionInDevelop(root, readResult);
    //        break;
    //    case "4":
    //        printer.PrintOptionInDevelop(root, readResult);
    //        break;
    //    case "5":
    //        printer.PrintOptionInDevelop(root, readResult);
    //        break;
    //    case "6":
    //        printer.PrintOptionInDevelop(root, readResult);
    //        break;
    //    case "7":
    //        printer.PrintOptionInDevelop(root, readResult);
    //        break;
    //    case "8":
    //        printer.PrintOptionInDevelop(root, readResult);
    //        break;
    //    case "exit":
    //        exit = true;
    //        break;
    //    default:
    //        Console.WriteLine($"{root.GetProperty("InvalidInput").GetString()}");
    //        break;
    //}    
}
