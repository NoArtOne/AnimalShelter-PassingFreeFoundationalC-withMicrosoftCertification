using AnimalShelter_PassingFreeFoundationalC_withMicrosoftCertification.Helpers;
using System;
using System.IO;
using System.IO.Pipelines;
using System.Reflection;
using System.Text.Json;

string jsonPath = Path.Combine(AppContext.BaseDirectory, "Resources", "Strings.en.json");
using JsonDocument doc = JsonDocument.Parse(File.ReadAllText(jsonPath));
JsonElement root = doc.RootElement;


// the ourAnimals array will store the following: 
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

// variables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";

// array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 6];


bool exit = false;

//Console.WriteLine($"You selected menu option {menuSelection}.");
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
        case "1":
            printer.PrintUserMenuOption(root, readResult);
            break;
        case "2":
            printer.PrintUserMenuOption(root, readResult);
            break;
        case "3":
            printer.PrintUserMenuOption(root, readResult);
            break;
        case "4":
            printer.PrintUserMenuOption(root, readResult);
            break;
        case "5":
            printer.PrintUserMenuOption(root, readResult);
            break;
        case "6":
            printer.PrintUserMenuOption(root, readResult);
            break;
        case "7":
            printer.PrintUserMenuOption(root, readResult);
            break;
        case "8":
            printer.PrintUserMenuOption(root, readResult);
            break;
        case "exit":
            exit = true;
            break;
        default:
            Console.WriteLine($"{root.GetProperty("InvalidInput").GetString()}");
            break;
    }
        

}


/*
int i = 0;

switch (i)
{
    case 0:
        animalSpecies = "dog";
        animalID = "d1";
        animalAge = "2";
        animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
        animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
        animalNickname = "lola";
        break;
    case 1:
        animalSpecies = "dog";
        animalID = "d2";
        animalAge = "9";
        animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
        animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
        animalNickname = "loki";
        break;
    case 2:
        animalSpecies = "cat";
        animalID = "c3";
        animalAge = "1";
        animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
        animalPersonalityDescription = "friendly";
        animalNickname = "Puss";
        break;
    case 3:
        animalSpecies = "cat";
        animalID = "c4";
        animalAge = "?";
        animalPhysicalDescription = "";
        animalPersonalityDescription = "";
        animalNickname = "";
        break;
    default:
        animalSpecies = "";
        animalID = "";
        animalAge = "";
        animalPhysicalDescription = "";
        animalPersonalityDescription = "";
        animalNickname = "";
        break;

}

switch (menuSelection)
{
    case "1":
        // List all of our current pet information
        Console.WriteLine("this app feature is coming soon - please check back to see progress.");
        Console.WriteLine("Press the Enter key to continue.");
        readResult = Console.ReadLine();
        break;

    case "2":
        // Add a new animal friend to the ourAnimals array
        Console.WriteLine("this app feature is coming soon - please check back to see progress.");
        Console.WriteLine("Press the Enter key to continue.");
        readResult = Console.ReadLine();
        break;

    case "3":
        // Add a new animal friend to the ourAnimals array
        Console.WriteLine("Challenge Project - please check back soon to see progress.");
        Console.WriteLine("Press the Enter key to continue.");
        readResult = Console.ReadLine();
        break;

    case "4":
        Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
        Console.WriteLine("Press the Enter key to continue.");
        readResult = Console.ReadLine();
        break;
    case "5":
        Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
        Console.WriteLine("Press the Enter key to continue.");
        readResult = Console.ReadLine();
        break;

    case "6":
        Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
        Console.WriteLine("Press the Enter key to continue.");
        readResult = Console.ReadLine();
        break;

    case "7":
        Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
        Console.WriteLine("Press the Enter key to continue.");
        readResult = Console.ReadLine();
        break;

    case "8":
        Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
        Console.WriteLine("Press the Enter key to continue.");
        readResult = Console.ReadLine();
        break;
}
*/
