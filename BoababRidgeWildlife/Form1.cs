using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BoababRidgeWildlife
{
    public partial class Form1 : Form
    {
        private readonly string filePath = "animals.txt";
        private Button btnDelete = new Button();

        public Form1()
        {
            InitializeComponent();

            btnDelete.Text = "Delete Animal";
            btnDelete.Location = new Point(20, 20);
            btnDelete.Click += btnDelete_Click;
            this.Controls.Add(btnDelete);

            LoadAnimalsData();
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
            string record = $"{animal.AnimalID} | {animal.Name} | {animal.Species} | {animal.Age} | {animal.RecoveryScore} | {status} | {housingUnit}";

            try
            {
                string existingContent = File.Exists(filePath) ? File.ReadAllText(filePath) : "";
                string prefix = (existingContent.Length > 0 && !existingContent.EndsWith(Environment.NewLine))
                    ? Environment.NewLine
                    : "";

                File.AppendAllText(filePath, prefix + record + Environment.NewLine);

                MessageBox.Show(
                    $"Animal added successfully!\n\nStatus: {status}\nHousing Unit: {housingUnit}",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadAnimalsData();

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

        private void LoadAnimalsData()
        {
            if (!File.Exists(filePath))
            {
                using (File.Create(filePath)) { }
            }

            if (dataGridView1.Columns.Count == 0)
            {
                dataGridView1.Columns.Add("ID", "Animal ID");
                dataGridView1.Columns.Add("Name", "Name");
                dataGridView1.Columns.Add("Species", "Species");
                dataGridView1.Columns.Add("Age", "Age");
                dataGridView1.Columns.Add("Score", "Recovery Score");
                dataGridView1.Columns.Add("Status", "Status");
                dataGridView1.Columns.Add("Housing", "Housing Unit");
            }

            dataGridView1.Rows.Clear();
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                string[] parts = line.Split('|');
                if (parts.Length >= 7)
                {
                    dataGridView1.Rows.Add(
                        parts[0].Trim(),
                        parts[1].Trim(),
                        parts[2].Trim(),
                        parts[3].Trim(),
                        parts[4].Trim(),
                        parts[5].Trim(),
                        parts[6].Trim());
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string selectedID = dataGridView1.SelectedRows[0].Cells["ID"].Value?.ToString() ?? "";
                string selectedName = dataGridView1.SelectedRows[0].Cells["Name"].Value?.ToString() ?? "";

                var confirmResult = MessageBox.Show(
                    $"Delete {selectedID} ({selectedName})? This cannot be undone.",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    string[] lines = File.ReadAllLines(filePath);
                    using (StreamWriter writer = new StreamWriter(filePath, false))
                    {
                        foreach (string line in lines)
                        {
                            if (string.IsNullOrWhiteSpace(line)) continue;
                            string[] parts = line.Split('|');

                            if (parts.Length > 0 && !parts[0].Trim().Equals(selectedID.Trim(), StringComparison.OrdinalIgnoreCase))
                            {
                                writer.WriteLine(line);
                            }
                        }
                    }

                    LoadAnimalsData();
                    MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select an entire row to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}