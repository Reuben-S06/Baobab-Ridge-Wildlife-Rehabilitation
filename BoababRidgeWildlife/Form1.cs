using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BoababRidgeWildlife
{
    public partial class Form1 : Form
    {
        private readonly string filePath = "animals.txt";

        public Form1()
        {
            InitializeComponent();
            LoadAnimalsData();
        }

        // Loads animal records from animals.txt
        private void LoadAnimalsData()
        {
            try
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
            catch (IOException)
            {
                MessageBox.Show(
                    "animals.txt could not be accessed because the file is currently in use.",
                    "File Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show(
                    "The application does not have permission to access animals.txt.",
                    "Permission Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Adds a new animal record
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string animalID = txtAnimalIDInput.Text.Trim();
            string name = txtNameInput.Text.Trim();
            string species = txtSpeciesInput.Text.Trim();
            string ageText = txtAgeInput.Text.Trim();
            string scoreText = txtRecoveryScoreInput.Text.Trim();

            if (animalID == "" || name == "" || species == "" || ageText == "" || scoreText == "")
            {
                MessageBox.Show("Please fill in all fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!animalID.StartsWith("WR-") || animalID.Length != 7 || !animalID.Substring(3).All(char.IsDigit))
            {
                MessageBox.Show("Animal ID must follow the format WR-0001.", "Invalid Animal ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (name.Length < 1 || name.Length > 30 || name.Contains('|') || name.Any(char.IsDigit))
            {
                MessageBox.Show("Name must be 1–30 characters and cannot contain numbers or '|'.", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNameInput.Focus();
                return;
            }

            if (species.Length < 1 || species.Length > 30 || species.Contains('|') || species.Any(char.IsDigit))
            {
                MessageBox.Show("Species must be 1–30 characters and cannot contain numbers or '|'.", "Invalid Species", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSpeciesInput.Focus();
                return;
            }

            if (!int.TryParse(ageText, out int age) || age < 0 || age > 100)
            {
                MessageBox.Show("Age must be a valid non-negative whole number (0-100).", "Invalid Age", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(scoreText, out int recoveryScore) || recoveryScore < 0 || recoveryScore > 100)
            {
                MessageBox.Show("Recovery score must be a whole number from 0 to 100.", "Invalid Recovery Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (File.Exists(filePath) &&
                File.ReadLines(filePath).Any(line =>
                    line.Split('|').Length > 0 &&
                    line.Split('|')[0].Trim().Equals(animalID, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("An animal with this ID already exists.", "Duplicate Animal ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Animal.Classify(recoveryScore, out string status, out string housingUnit);
            Animal animal = new Animal(animalID, name, species, age, recoveryScore);

            string record = $"{animal.AnimalID} | {animal.Name} | {animal.Species} | {animal.Age} | {animal.RecoveryScore} | {status} | {housingUnit}";

            try
            {
                string existingContent = File.Exists(filePath) ? File.ReadAllText(filePath) : "";
                string prefix = (existingContent.Length > 0 && !existingContent.EndsWith(Environment.NewLine))
                    ? Environment.NewLine
                    : "";

                File.AppendAllText(filePath, prefix + record + Environment.NewLine);

                MessageBox.Show($"Animal added successfully!\n\nStatus: {status}\nHousing Unit: {housingUnit}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadAnimalsData();

                txtAnimalIDInput.Clear();
                txtNameInput.Clear();
                txtSpeciesInput.Clear();
                txtAgeInput.Clear();
                txtRecoveryScoreInput.Clear();
                txtAnimalIDInput.Focus();
            }
            catch (IOException)
            {
                MessageBox.Show("The animal record could not be saved. Please check that the file is accessible.", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("The application does not have permission to write to the animal records file.", "Permission Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Deletes the selected animal record
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
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
            catch (IOException)
            {
                MessageBox.Show(
                    "The animal record could not be deleted because animals.txt is currently in use.",
                    "File Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show(
                    "The application does not have permission to modify animals.txt.",
                    "Permission Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchId = txtSearchID.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchId))
            {
                MessageBox.Show("Please enter an Animal ID to search.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool found = false;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["ID"].Value != null &&
                    row.Cells["ID"].Value.ToString().Trim().Equals(searchId, StringComparison.OrdinalIgnoreCase))
                {
                    row.Selected = true;
                    dataGridView1.CurrentCell = row.Cells[0];

                    txtAnimalIDInput.Text = row.Cells["ID"].Value?.ToString() ?? "";
                    txtNameInput.Text = row.Cells["Name"].Value?.ToString() ?? "";
                    txtSpeciesInput.Text = row.Cells["Species"].Value?.ToString() ?? "";
                    txtAgeInput.Text = row.Cells["Age"].Value?.ToString() ?? "";
                    txtRecoveryScoreInput.Text = row.Cells["Score"].Value?.ToString() ?? "";

                    txtAnimalIDInput.ReadOnly = true;
                    btnSaveChanges.Enabled = true;
                    btnAdd.Enabled = false;

                    found = true;
                    break;
                }
            }

            if (!found)
            {
                MessageBox.Show($"No animal found with ID '{searchId}'.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Updates the selected animal record
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            string targetID = txtAnimalIDInput.Text.Trim();
            string name = txtNameInput.Text.Trim();
            string species = txtSpeciesInput.Text.Trim();
            string ageText = txtAgeInput.Text.Trim();
            string scoreText = txtRecoveryScoreInput.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(species) ||
                string.IsNullOrWhiteSpace(ageText) || string.IsNullOrWhiteSpace(scoreText))
            {
                MessageBox.Show("Please fill in all fields before updating.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (name.Length < 1 || name.Length > 30 || name.Contains('|') || name.Any(char.IsDigit))
            {
                MessageBox.Show("Name must be 1–30 characters and cannot contain numbers or '|'.", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNameInput.Focus();
                return;
            }

            if (species.Length < 1 || species.Length > 30 || species.Contains('|') || species.Any(char.IsDigit))
            {
                MessageBox.Show("Species must be 1–30 characters and cannot contain numbers or '|'.", "Invalid Species", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSpeciesInput.Focus();
                return;
            }

            if (!int.TryParse(ageText, out int age) || age < 0 || age > 100)
            {
                MessageBox.Show("Age must be a valid whole number (0-100).", "Invalid Age", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(scoreText, out int recoveryScore) || recoveryScore < 0 || recoveryScore > 100)
            {
                MessageBox.Show("Recovery score must be a whole number between 0 and 100.", "Invalid Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Animal.Classify(recoveryScore, out string status, out string housingUnit);
            string updatedRecord = $"{targetID} | {name} | {species} | {age} | {recoveryScore} | {status} | {housingUnit}";

            try
            {
                string[] lines = File.ReadAllLines(filePath);
                using (StreamWriter writer = new StreamWriter(filePath, false))
                {
                    foreach (string line in lines)
                    {
                        if (string.IsNullOrWhiteSpace(line)) continue;

                        string[] parts = line.Split('|');
                        if (parts.Length > 0 && parts[0].Trim().Equals(targetID, StringComparison.OrdinalIgnoreCase))
                        {
                            writer.WriteLine(updatedRecord);
                        }
                        else
                        {
                            writer.WriteLine(line);
                        }
                    }
                }

                LoadAnimalsData();
                btnClear_Click(null, null);
                MessageBox.Show("Animal record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (IOException)
            {
                MessageBox.Show("Could not update the file. Ensure it is not locked by another process.", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show(
                    "The application does not have permission to modify animals.txt.",
                    "Permission Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearchID.Clear();
            txtAnimalIDInput.Clear();
            txtNameInput.Clear();
            txtSpeciesInput.Clear();
            txtAgeInput.Clear();
            txtRecoveryScoreInput.Clear();

            txtAnimalIDInput.ReadOnly = false;
            btnSaveChanges.Enabled = false;
            btnAdd.Enabled = true;
            dataGridView1.ClearSelection();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtAnimalIDInput.Text = row.Cells["ID"].Value?.ToString() ?? "";
                txtNameInput.Text = row.Cells["Name"].Value?.ToString() ?? "";
                txtSpeciesInput.Text = row.Cells["Species"].Value?.ToString() ?? "";
                txtAgeInput.Text = row.Cells["Age"].Value?.ToString() ?? "";
                txtRecoveryScoreInput.Text = row.Cells["Score"].Value?.ToString() ?? "";

                txtAnimalIDInput.ReadOnly = true;
                btnSaveChanges.Enabled = true;
                btnAdd.Enabled = false;
            }
        }

        private void btnGenerateSummary_Click(object sender, EventArgs e)
        {
            try
            {
                int totalAnimals = 0;
                int totalAge = 0;
                int totalRecoveryScore = 0;

                int criticalCount = 0;
                int seriousCount = 0;
                int stableCount = 0;
                int recoveringCount = 0;
                int releaseReadyCount = 0;

                if (File.Exists(filePath))
                {
                    string[] lines = File.ReadAllLines(filePath);

                    foreach (string line in lines)
                    {
                        if (string.IsNullOrWhiteSpace(line))
                            continue;

                        string[] parts = line.Split('|');

                        if (parts.Length != 7)
                            continue;

                        string animalID = parts[0].Trim();

                        if (animalID.Length != 7 || !animalID.StartsWith("WR-") || !animalID.Substring(3).All(char.IsDigit))
                        {
                            continue;
                        }

                        if (!int.TryParse(parts[3].Trim(), out int age))
                            continue;

                        if (!int.TryParse(parts[4].Trim(), out int recoveryScore))
                            continue;

                        string status = parts[5].Trim();

                        totalAnimals++;
                        totalAge += age;
                        totalRecoveryScore += recoveryScore;

                        switch (status)
                        {
                            case "Critical":
                                criticalCount++;
                                break;

                            case "Serious":
                                seriousCount++;
                                break;

                            case "Stable":
                                stableCount++;
                                break;

                            case "Recovering":
                                recoveringCount++;
                                break;

                            case "Release-Ready":
                                releaseReadyCount++;
                                break;
                        }
                    }
                }

                string averageAge;
                string averageRecoveryScore;

                if (totalAnimals == 0)
                {
                    averageAge = "N/A";
                    averageRecoveryScore = "N/A";
                }
                else
                {
                    averageAge = ((double)totalAge / totalAnimals)
                        .ToString("F2", CultureInfo.InvariantCulture);

                    averageRecoveryScore = ((double)totalRecoveryScore / totalAnimals)
                        .ToString("F2", CultureInfo.InvariantCulture);
                }

                lblTotalAnimals.Text = totalAnimals.ToString();
                lblAverageAge.Text = averageAge;
                lblAverageScore.Text = averageRecoveryScore;

                lblCritical.Text = criticalCount.ToString();
                lblSerious.Text = seriousCount.ToString();
                lblStable.Text = stableCount.ToString();
                lblRecovering.Text = recoveringCount.ToString();
                lblReleaseReady.Text = releaseReadyCount.ToString();

                string summaryPath = Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory,
                    "summary.txt");

                string summary =
                    "BAOBAB RIDGE WILDLIFE REHABILITATION CENTRE" + Environment.NewLine +
                    "ANIMAL SUMMARY REPORT" + Environment.NewLine +
                    "Generated: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm") + Environment.NewLine +
                    "----------------------------------------" + Environment.NewLine +
                    $"Total animals: {totalAnimals}" + Environment.NewLine +
                    $"Average age (years): {averageAge}" + Environment.NewLine +
                    $"Average recovery score: {averageRecoveryScore}" + Environment.NewLine +
                    "----------------------------------------" + Environment.NewLine +
                    "Animals per status:" + Environment.NewLine +
                    $"Critical: {criticalCount}" + Environment.NewLine +
                    $"Serious: {seriousCount}" + Environment.NewLine +
                    $"Stable: {stableCount}" + Environment.NewLine +
                    $"Recovering: {recoveringCount}" + Environment.NewLine +
                    $"Release-Ready: {releaseReadyCount}";

                // Overwrite summary.txt each time a new summary is generated.
                File.WriteAllText(summaryPath, summary);

                MessageBox.Show(
                    "Summary report generated successfully.",
                    "Summary Report",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (IOException)
            {
                MessageBox.Show(
                    "The summary report could not be generated because a file is currently in use.",
                    "File Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show(
                    "The application does not have permission to access the required file.",
                    "Permission Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}