using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleView.Views;

internal class ViewAllAnimalsInfo : View
{
    public new void Show(Animal animal) => Console.WriteLine("" +
        "ID: {0} \nNickname: {1} \nPersonality: {2} \n" +
        "Physical: {3} \nAge: {4} \nSpecies: {5}\n",
        animal.AnimalID,
        animal.AnimalNickname,
        animal.AnimalPersonalityDescription,
        animal.AnimalPhysicalDescription,
        animal.AnimalAge,
        animal.AnimalSpecies);
}
