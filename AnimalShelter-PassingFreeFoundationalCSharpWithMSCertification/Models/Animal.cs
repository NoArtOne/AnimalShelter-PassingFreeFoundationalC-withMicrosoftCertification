using ENUM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models;

public class Animal
{
    public required AnimalSpecies AnimalSpecies { get; set; }
    public string? AnimalID { get; set; }
    public required int? AnimalAge { get; set; }
    public required string AnimalPhysicalDescription { get; set; }
    public required string AnimalPersonalityDescription { get; set; }
    public required string AnimalNickname { get; set; }
}
