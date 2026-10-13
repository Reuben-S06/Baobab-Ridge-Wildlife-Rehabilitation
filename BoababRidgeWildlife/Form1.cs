
using BaobabRidgeWildlife;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BoababRidgeWildlife
{
    public partial class Form1 : Form
    {
        private readonly string filePath =
    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "animals.txt");
        public Form1()
        {
            InitializeComponent();

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {


            string animalID = txtAnimalIDInput.Text.Trim();
            string name = txtNameInput.Text.Trim();
            string species = txtSpeciesInput.Text.Trim();
            string ageText = txtAgeInput.Text.Trim();
            string scoreText = txtRecoveryScoreInput.Text.Trim();

            // Check required fields
            if (animalID == "" || name == "" || species == "" ||
                ageText == "" || scoreText == "")
            {
                MessageBox.Show("Please fill in all fields.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Validate Animal ID
            if (!animalID.StartsWith("WR-") ||
                animalID.Length != 7 ||
                !animalID.Substring(3).All(char.IsDigit))
            {
                MessageBox.Show("Animal ID must follow the format WR-0001.",
                    "Invalid Animal ID",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Validate name and species
            if (name.Any(char.IsDigit) || species.Any(char.IsDigit))
            {
                MessageBox.Show("Name and species cannot contain numbers.",
                    "Invalid Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Validate age
            if (!int.TryParse(ageText, out int age) || age < 0)
            {
                MessageBox.Show("Age must be a valid non-negative whole number.",
                    "Invalid Age",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Validate recovery score
            if (!int.TryParse(scoreText, out int recoveryScore) ||
                recoveryScore < 0 || recoveryScore > 100)
            {
                MessageBox.Show("Recovery score must be a whole number from 0 to 100.",
                    "Invalid Recovery Score",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Check for duplicate Animal ID
            if (File.Exists(filePath) &&
                File.ReadLines(filePath).Any(line =>
                    line.Split('|').Length > 0 &&
                    line.Split('|')[0].Trim().Equals(
                        animalID, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("An animal with this ID already exists.",
                    "Duplicate Animal ID",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Classify the animal using the shared Animal class
            Animal.Classify(recoveryScore, out string status, out string housingUnit);

            // Create the animal record
            Animal animal = new Animal(animalID, name, species, age, recoveryScore);

            // Save the record using the required pipe-separated format
            string record = $"{animal.AnimalID}|{animal.Name}|{animal.Species}|{animal.Age}|{animal.RecoveryScore}|{status}|{housingUnit}";

            try
            {
                File.AppendAllText(
                    filePath,
                 (File.ReadAllText(filePath).Length > 0 &&
                 !File.ReadAllText(filePath).EndsWith(Environment.NewLine)
                 ? Environment.NewLine
                 : "") + record + Environment.NewLine);

                MessageBox.Show(
                    $"Animal added successfully!\n\nStatus: {status}\nHousing Unit: {housingUnit}",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Clear the form for the next animal
                txtAnimalIDInput.Clear();
                txtNameInput.Clear();
                txtSpeciesInput.Clear();
                txtAgeInput.Clear();
                txtRecoveryScoreInput.Clear();

                txtAnimalIDInput.Focus();
            }
            catch (IOException)
            {
                MessageBox.Show(
                    "The animal record could not be saved. Please check that the file is accessible.",
                    "File Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show(
                    "The application does not have permission to write to the animal records file.",
                    "Permission Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
    
}
