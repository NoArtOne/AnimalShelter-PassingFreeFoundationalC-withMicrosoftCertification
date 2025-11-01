using ENUM;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Service;
/// <summary>
/// Хранилище животных, которые есть в приюте
/// </summary>
public class AnimalStorage
{
    private const int MaxPets = 8;
    private Animal[] _animals = new Animal[MaxPets];

    public AnimalStorage() 
    {
        _animals = AddSampleAnimals();
    }

    private Animal[] AddSampleAnimals()
    {
        for (int i = 0; i < MaxPets; i++)
        {
            _animals[i] = i switch
            {
                0 => new Animal
                {
                    AnimalAge = 2,
                    AnimalNickname = "lola",
                    AnimalPersonalityDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.",
                    AnimalPhysicalDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.",
                    AnimalSpecies = AnimalSpecies.Dog,
                    AnimalID = Guid.NewGuid().ToString("N")
                },
                1 => new Animal
                {
                    AnimalAge = 9,
                    AnimalNickname = "loki",
                    AnimalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.",
                    AnimalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.",
                    AnimalSpecies = AnimalSpecies.Dog,
                    AnimalID = Guid.NewGuid().ToString("N")
                },
                2 => new Animal
                {
                    AnimalAge = 1,
                    AnimalNickname = "Puss",
                    AnimalPersonalityDescription = "friendly",
                    AnimalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.",
                    AnimalSpecies = AnimalSpecies.Cat,
                    AnimalID = Guid.NewGuid().ToString("N")
                },
                3 => new Animal
                {
                    AnimalAge = null,
                    AnimalNickname = "",
                    AnimalPersonalityDescription = "",
                    AnimalPhysicalDescription = "",
                    AnimalSpecies = AnimalSpecies.Cat,
                    AnimalID = Guid.NewGuid().ToString("N")
                },
                _ => new Animal
                {
                    AnimalAge = null,
                    AnimalNickname = "",
                    AnimalPersonalityDescription = "",
                    AnimalPhysicalDescription = "",
                    AnimalID = null,
                    AnimalSpecies = AnimalSpecies.Unknown
                },
            };
        }
        return _animals;
    }
    public void AddNewAnimal(
        int age, string nickname,
        string personalityDescription,
        string physicalDescription,
        AnimalSpecies animalSpecies)
    {
        bool successAddNewAnimal = false;
        foreach (Animal animal in _animals)
        {
            if (animal.AnimalID == null)
            {

                animal.AnimalID = Guid.NewGuid().ToString("N");
                animal.AnimalAge = age;
                animal.AnimalNickname = nickname;
                animal.AnimalPersonalityDescription = personalityDescription;
                animal.AnimalPhysicalDescription = physicalDescription;
                animal.AnimalSpecies = animalSpecies;
                successAddNewAnimal = true;
                Console.WriteLine("Successfully added a new animal to the shelter");
                break;
            }
            else
            {
                Console.WriteLine("Couldn't add a new animal. There are too many animals in the shelter");
            }
        }
// добавить get animals, update, delete, read list, добавить current_value_of_pets
    }
}

