using System;
using System.IO;
using System.Windows.Forms;

namespace BoababRidgeWildlife
{
    public partial class Form1 : Form
    {
        private string filepath = "animals.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadAnimalsData();
        }

        private void LoadAnimalsData()
        {
            if (!File.Exists(filepath))
            {
                using (File.Create(filepath)) { }
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
            string[] lines = File.ReadAllLines(filepath);
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
                    string[] lines = File.ReadAllLines(filepath);
                    using (StreamWriter writer = new StreamWriter(filepath, false))
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