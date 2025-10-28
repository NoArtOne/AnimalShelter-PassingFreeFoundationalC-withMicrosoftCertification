using Factory;
using Helpers;
using Helpers;
using Models;
using System;
using System.IO;
using System.IO.Pipelines;
using System.Reflection;
using System.Text.Json;

string jsonPath = Path.Combine(AppContext.BaseDirectory, "Resources", "Strings.en.json");
using JsonDocument doc = JsonDocument.Parse(File.ReadAllText(jsonPath));
JsonElement root = doc.RootElement;

string? readResult;
bool exit = false;

var ourAnimals = AnimalFactory.CreateSampleAnimals();

while (!exit)
{
    Console.WriteLine($"{root.GetProperty("MenuHeader").GetString()}{root.GetProperty("MenuOptions").GetString()}");
    Console.WriteLine($"{root.GetProperty("ExitInput").GetString()}");
    readResult = Console.ReadLine();
    if (readResult == null) 
    {
        Console.WriteLine($"{root.GetProperty("EmptyInput").GetString()}");
        continue;
    }
    RepeatedPrintText printer = new();

    switch (readResult)
    {
        case "1": // Вывод информации о всех животных в приюте
            printer.PrintUserOption(root, readResult);
            for (int i = 0; i < AnimalFactory.MaxPets; i++)
            {
                if (ourAnimals[i].AnimalID != null)
                {
                    Console.WriteLine(
                        "ID: {0} \nNickname: {1} \nPersonality: {2} \n" +
                        "Physical: {3} \nAge: {4} \nSpecies: {5}\n",
                        ourAnimals[i].AnimalID,
                        ourAnimals[i].AnimalNickname,
                        ourAnimals[i].AnimalPersonalityDescription,
                        ourAnimals[i].AnimalPhysicalDescription,
                        ourAnimals[i].AnimalAge,
                        ourAnimals[i].AnimalSpecies
                        );
                }
            }
            printer.PrintInputAnyToContinue(root);
            break;
        case "2": // Добавьте нового друга-животное в массив ourAnimals
            printer.PrintUserOption(root, readResult);
            int petCount = 0;
            for (int i = 0; i < AnimalFactory.MaxPets; i++)
            {
                if (ourAnimals[i].AnimalID != null)
                {
                    petCount += 1;
                }
            }

            if (petCount < AnimalFactory.MaxPets)
            {
                bool exitOptionTwo = false;
                while (petCount < AnimalFactory.MaxPets && exitOptionTwo == false)
                {
                    Console.WriteLine($"We currently have {petCount} pets that need homes. " +
                   $"We can manage {(AnimalFactory.MaxPets - petCount)} more.");
                    Console.WriteLine("Do you want to enter info for another pet (y/n)");

                    string readResultFromOptionTwo = Console.ReadLine();
                    if (readResultFromOptionTwo == null)
                    {
                        Console.WriteLine($"{root.GetProperty("EmptyInput").GetString()}");
                        continue;
                    }

                    switch (readResultFromOptionTwo)
                    {
                        case "y":
                            petCount += 1;
                            if (petCount >= AnimalFactory.MaxPets)
                                Console.WriteLine($"{root.GetProperty("ReachedLimitPetsInShelter").GetString()}"); break;
                        case "n":
                            exitOptionTwo = true;
                            break;

                        default:
                            Console.WriteLine($"{root.GetProperty("InvalidInput").GetString()}");
                            break;
                    }
                }
           
            }
            else
            {
                Console.WriteLine($"{root.GetProperty("ReachedLimitPetsInShelter").GetString()}"); break;
                printer.PrintInputAnyToContinue(root);
            }
            printer.PrintInputAnyToContinue(root);
            break;
        case "3":
            printer.PrintOptionInDevelop(root, readResult);
            break;
        case "4":
            printer.PrintOptionInDevelop(root, readResult);
            break;
        case "5":
            printer.PrintOptionInDevelop(root, readResult);
            break;
        case "6":
            printer.PrintOptionInDevelop(root, readResult);
            break;
        case "7":
            printer.PrintOptionInDevelop(root, readResult);
            break;
        case "8":
            printer.PrintOptionInDevelop(root, readResult);
            break;
        case "exit":
            exit = true;
            break;
        default:
            Console.WriteLine($"{root.GetProperty("InvalidInput").GetString()}");
            break;
    }    
}
