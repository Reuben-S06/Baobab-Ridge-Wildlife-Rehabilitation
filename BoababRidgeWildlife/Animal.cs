using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoababRidgeWildlife
{
    public class Animal
    {
        public string AnimalID { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public int Age { get; set; }
        public int RecoveryScore { get; set; }
        public string Status { get; set; }
        public string HousingUnit { get; set; }

        public Animal() { }

        public Animal(string animalID, string name, string species, int age, int recoveryScore)
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
            if (score >= 1 && score <= 50)
            {
                status = "Critical";
                housingUnit = "ICU";
            }
            else if (score >= 51 && score <= 79)
            {
                status = "Stable";
                housingUnit = "General Ward";
            }
            else if (score >= 80 && score <= 100)
            {
                status = "Ready for Release";
                housingUnit = "Pre-Release Enclosure";
            }
            else
            {
                status = "Unknown";
                housingUnit = "Quarantine";
            }
        }

        public override string ToString()
        {
            return $"{AnimalID} | {Name} | {Species} | {Age} | {RecoveryScore} | {Status} | {HousingUnit}";
        }
    }
}