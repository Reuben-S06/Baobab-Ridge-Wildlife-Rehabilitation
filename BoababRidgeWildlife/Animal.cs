using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaobabRidgeWildlife
{
    internal class Animal
    {
        public string AnimalID { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public int Age { get; set; }
        public int RecoveryScore { get; set; }
        public string Status { get; set; }
        public string HousingUnit { get; set; }

        public Animal(string animalID, string name, string species,
                      int age, int recoveryScore)
        {
            AnimalID = animalID;
            Name = name;
            Species = species;
            Age = age;
            RecoveryScore = recoveryScore;

            Classify(recoveryScore, out string status, out string housingUnit);
            Status = status;
            HousingUnit = housingUnit;
        }

        public static void Classify(int score, out string status, out string housingUnit)
        {
            if (score >= 0 && score <= 19)
            {
                status = "Critical";
                housingUnit = "Intensive Care Unit";
            }
            else if (score <= 39)
            {
                status = "Serious";
                housingUnit = "High-Dependency Ward";
            }
            else if (score <= 59)
            {
                status = "Stable";
                housingUnit = "Recovery Ward";
            }
            else if (score <= 79)
            {
                status = "Recovering";
                housingUnit = "Outdoor Enclosure";
            }
            else if (score <= 100)
            {
                status = "Release-Ready";
                housingUnit = "Pre-Release Camp";
            }
            else
            {
                status = "Unknown";
                housingUnit = "Unknown";
            }
        }
    }
}
