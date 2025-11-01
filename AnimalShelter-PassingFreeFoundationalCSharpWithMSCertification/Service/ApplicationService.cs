using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service;
/// <summary>
/// Responsible for the bines logic between Views and AnimalStorage (crud)
/// Отвечает за бинес-логику между Views и AnimalStorage (crud)
/// </summary>
public class ApplicationService
{
    private AnimalStorage animalStorage = new();
    ApplicationService() {
    
    }

    public string ValidateForEmptyReadInput(string userEnteredText)
    {
        if (userEnteredText == null) return null;
        else
            return userEnteredText;
    }
}
