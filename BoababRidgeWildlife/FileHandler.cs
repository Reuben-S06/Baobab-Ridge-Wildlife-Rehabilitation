using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoababRidgeWildlife
{
    internal class FileHandler
    {
        private string filePath;

        public FileHandler(string path = "animals.txt")
        {
            filePath = path;
        }

        public List<Animal> ReadAnimals(out int skippedCount)
        {
            skippedCount = 0;
            List<Animal> animals = new List<Animal>();

            if (!File.Exists(filePath))
            {
                using (File.Create(filePath)) { }
                return animals;
            }

            try
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line))
                    {
                        continue;
                    }

                    string[] parts = line.Split('|');
                    if (parts.Length != 7)
                    {
                        skippedCount++;
                        continue;
                    }

                    string id = parts[0].Trim();
                    string name = parts[1].Trim();
                    string species = parts[2].Trim();
                    string ageStr = parts[3].Trim();
                    string scoreStr = parts[4].Trim();

                    if (!int.TryParse(ageStr, out int age) || !int.TryParse(scoreStr, out int score) || age < 0 || age > 100 || score < 0 || score > 100)
                    {
                        skippedCount++;
                        continue;
                    }

                    Animal animal = new Animal(id, name, species, age, score);
                    animals.Add(animal);
                }
            }
            catch (IOException ex)
            {
                throw new IOException($"Could not read file: {ex.Message}");
            }
            catch (UnauthorizedAccessException ex)
            {
                throw new UnauthorizedAccessException($"Permission error reading file: {ex.Message}");
            }

            return animals;
        }

        public Animal? FindAnimalByID(string animalId)
        {
            List<Animal> animals = ReadAnimals(out _);
            string searchTarget = animalId.Trim().ToUpper();

            foreach (Animal a in animals)
            {
                if (a.AnimalID.Trim().ToUpper() == searchTarget)
                {
                    return a;
                }
            }

            return null;
        }

        public bool UpdateAnimal(Animal updatedAnimal)
        {
            try
            {
                List<Animal> animals = ReadAnimals(out _);
                bool found = false;

                for (int i = 0; i < animals.Count; i++)
                {
                    if (animals[i].AnimalID.Trim().ToUpper() == updatedAnimal.AnimalID.Trim().ToUpper())
                    {
                        animals[i] = updatedAnimal;
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    return false;
                }

                List<string> linesToWrite = new List<string>();
                foreach (Animal a in animals)
                {
                    linesToWrite.Add(a.ToString());
                }

                File.WriteAllLines(filePath, linesToWrite);
                return true;
            }
            catch (IOException ex)
            {
                throw new IOException($"File is currently locked or in use: {ex.Message}");
            }
            catch (UnauthorizedAccessException ex)
            {
                throw new UnauthorizedAccessException($"Access denied when updating file: {ex.Message}");
            }
        }
    }
}
