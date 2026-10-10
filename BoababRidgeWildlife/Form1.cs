using System;
using System.IO; 
using System.Windows.Forms; 

namespace BoababRidgeWildlife
{
    public partial class Form1 : Form
    {
        private string filepath = "animals.txt";
        private Button btnDelete = new Button();
        public Form1()
        {
            InitializeComponent();
            btnDelete.Text = "Delete Animal";
            btnDelete.Location = new System.Drawing.Point(20,20);
            btnDelete.Click += btnDelete_Click;
            this.Controls.Add(btnDelete);
            LoadAnimalsData(); 
        }
    }
} 

private void LoadAnimalsData()
{
  if (!File.Exists(filepath))
  {
    File.Create(filepath).Close();
  }
  if (dataGridView1.Columns.Count == 0)
  {
    dataGridView1.Columns.Add("ID", "Animal ID");
    dataGridView1.Columns.Add("Name", "Name");
    dataGridView1.Columns.Add("Species", "Species");
    dataGridView1.Columns.Add("Age", "Age");
    dataGridView1.Columns.Add("Score", "Score");
    dataGridView1.Columns.Add("Status", "Status");
    dataGridView1.Columns.Add("Housing", "Housing");
  }

  dataGridView1.Rows.Clear();
  string[] lines = File.ReadAllLines(filepath);
  foreach (string line in lines)
  {
    if (string.IsNullOrWhiteSpace(line)) continue;

    string[] parts = line.Split('|');
    if (parts.Length >= 7)
    {
        dataGridView1.Rows.Add(parts[0], parts[1], parts[2], parts[3], parts[4], parts[5], parts[6]); 
    }
  }
}

private void btnDelte_Click(object sender, EventArgs e)
{
    if (dataGridView1.SelectedRows.Count > 0)
    {
        var confirmResult = MessageBox.Show("Are you sure you want to delete this animal record?", "Confirm Deletion", MessageBoxButtons. YesNo, MessageBoxIcon.Warning);

        if (confirmResult == DialogResult.Yes)
        {
            string selected = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            
            string[]lines = File.ReadAllLines(filepath);
            using (StreamWriter writer = new StreamWriter(filepath, false))
            {
                foreach (string line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue; 
                    string[] parts= line.Split('|');

                    if (parts.Length > 0 && parts[0] != selectedID)
                    {
                        writer.writeLine(line);
                    }
                }
            }
            LoadAnimalsData();
            MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons. OK, MessageBoxIcon.Information);
        }
    } 
    else
    {
        MessageBox.Show("Please select an entire row to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
    }
}

