using System;
using System.Collections.Generic;
using System.IO.Pipelines;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace AnimalShelter_PassingFreeFoundationalC_withMicrosoftCertification.Helpers
{
    internal class RepeatedPrintText
    {
        public void PrintUserMenuOption(JsonElement root, string readResult) 
        {
            Console.WriteLine($"{root.GetProperty("SelectedOption").GetString()}{readResult}.");
            Console.WriteLine($"{root.GetProperty("ThisFeatureInDeveloping").GetString()}");
            Console.WriteLine($"{root.GetProperty("NotificationPressToContinue").GetString()}");
        }
    }
}
