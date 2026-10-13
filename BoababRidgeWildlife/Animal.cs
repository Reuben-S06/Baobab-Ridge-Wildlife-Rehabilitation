using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoababRidgeWildlife
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

        public Animal (string animalID, string name, string species, int age, int recoveryScore, string status, string housingUnit)
        {
            AnimalID = animalID;
            Name = name;
            Species = species;
            Age = age;
            RecoveryScore = recoveryScore;
            Classify(recoveryScore, out string calculatedStatus, out string calculatedHousing);
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
            else if (score >= 20 && score <= 39)
            {
                status = "Serious";
                housingUnit = "High-Dependency Ward";
            }
            else if (score >= 40 && score <= 59)
            {
                status = "Stable";
                housingUnit = "Recovery Ward";
            }
            else if (score >= 60 && score <= 79)
            {
                status = "Recovering";
                housingUnit = "Outdoor Enclosure";
            }
            else if (score >= 80 && score <= 100)
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

        public override string ToString()
        {
            return $"{AnimalID} | {Name} | {Species} | {Age} | {RecoveryScore} | {Status} | {HousingUnit}";
        }
    }
}
