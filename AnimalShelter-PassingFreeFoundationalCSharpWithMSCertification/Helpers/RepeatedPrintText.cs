using System;
using System.Collections.Generic;
using System.IO.Pipelines;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Helpers;
internal class RepeatedPrintText()
{
    public void PrintOptionInDevelop(JsonElement root, string readResult)
    {
        Console.WriteLine($"{root.GetProperty("SelectedOption").GetString()}{readResult}.");
        Console.WriteLine($"{root.GetProperty("ThisFeatureInDeveloping").GetString()}");
        Console.WriteLine($"{root.GetProperty("NotificationPressToContinue").GetString()}");
    }
    public void PrintUserOption(JsonElement root, string readResult)
    {
        Console.WriteLine($"{root.GetProperty("SelectedOption").GetString()}{readResult}.");

    }

    public void PrintInputAnyToContinue(JsonElement root)
    {
        Console.WriteLine($"{root.GetProperty("InputAnyKeyToContinue").GetString()}");
        Console.ReadKey();
    }

    public static string ValidateForEmptyReadInput(JsonElement root)
    {
        string? input = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine(root.GetProperty("EmptyInput").GetString());
            return null;
        }
        return input;
    }
}

