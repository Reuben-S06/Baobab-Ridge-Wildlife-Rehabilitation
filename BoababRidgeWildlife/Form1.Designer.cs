namespace BoababRidgeWildlife
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtAnimalID = new Label();
            txtName = new Label();
            txtSpecies = new Label();
            txtAge = new Label();
            txtRecoveryScore = new Label();
            txtNameInput = new TextBox();
            txtAnimalIDInput = new TextBox();
            txtSpeciesInput = new TextBox();
            txtAgeInput = new TextBox();
            txtRecoveryScoreInput = new TextBox();
            btnAdd = new Button();
            textBox6 = new TextBox();
            dataGridView1 = new DataGridView();
            btnDelete = new Button();
            label1 = new Label();
            btnSearch = new Button();
            btnSaveChanges = new Button();
            btnClear = new Button();
            txtSearchID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtAnimalID
            // 
            txtAnimalID.AutoSize = true;
            txtAnimalID.Location = new Point(14, 87);
            txtAnimalID.Name = "txtAnimalID";
            txtAnimalID.Size = new Size(75, 20);
            txtAnimalID.TabIndex = 0;
            txtAnimalID.Text = "Animal ID";
            // 
            // txtName
            // 
            txtName.AutoSize = true;
            txtName.Location = new Point(14, 163);
            txtName.Name = "txtName";
            txtName.Size = new Size(49, 20);
            txtName.TabIndex = 1;
            txtName.Text = "Name";
            // 
            // txtSpecies
            // 
            txtSpecies.AutoSize = true;
            txtSpecies.Location = new Point(14, 237);
            txtSpecies.Name = "txtSpecies";
            txtSpecies.Size = new Size(59, 20);
            txtSpecies.TabIndex = 2;
            txtSpecies.Text = "Species";
            // 
            // txtAge
            // 
            txtAge.AutoSize = true;
            txtAge.Location = new Point(14, 321);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(80, 20);
            txtAge.TabIndex = 3;
            txtAge.Text = "Age(years)";
            // 
            // txtRecoveryScore
            // 
            txtRecoveryScore.AutoSize = true;
            txtRecoveryScore.Location = new Point(14, 409);
            txtRecoveryScore.Name = "txtRecoveryScore";
            txtRecoveryScore.Size = new Size(110, 20);
            txtRecoveryScore.TabIndex = 4;
            txtRecoveryScore.Text = "Recovery Score";
            // 
            // txtNameInput
            // 
            txtNameInput.Location = new Point(14, 187);
            txtNameInput.Margin = new Padding(3, 4, 3, 4);
            txtNameInput.Name = "txtNameInput";
            txtNameInput.Size = new Size(114, 27);
            txtNameInput.TabIndex = 5;
            // 
            // txtAnimalIDInput
            // 
            txtAnimalIDInput.Location = new Point(14, 111);
            txtAnimalIDInput.Margin = new Padding(3, 4, 3, 4);
            txtAnimalIDInput.Name = "txtAnimalIDInput";
            txtAnimalIDInput.Size = new Size(114, 27);
            txtAnimalIDInput.TabIndex = 6;
            // 
            // txtSpeciesInput
            // 
            txtSpeciesInput.Location = new Point(14, 261);
            txtSpeciesInput.Margin = new Padding(3, 4, 3, 4);
            txtSpeciesInput.Name = "txtSpeciesInput";
            txtSpeciesInput.Size = new Size(114, 27);
            txtSpeciesInput.TabIndex = 7;
            // 
            // txtAgeInput
            // 
            txtAgeInput.Location = new Point(14, 345);
            txtAgeInput.Margin = new Padding(3, 4, 3, 4);
            txtAgeInput.Name = "txtAgeInput";
            txtAgeInput.Size = new Size(114, 27);
            txtAgeInput.TabIndex = 8;
            // 
            // txtRecoveryScoreInput
            // 
            txtRecoveryScoreInput.Location = new Point(14, 433);
            txtRecoveryScoreInput.Margin = new Padding(3, 4, 3, 4);
            txtRecoveryScoreInput.Name = "txtRecoveryScoreInput";
            txtRecoveryScoreInput.Size = new Size(114, 27);
            txtRecoveryScoreInput.TabIndex = 9;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(14, 485);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(202, 31);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add Animal";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(14, 16);
            textBox6.Margin = new Padding(3, 4, 3, 4);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(228, 27);
            textBox6.TabIndex = 11;
            textBox6.Text = "Baobab Ridge Wildlife Rehabilitation";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(400, 12);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(502, 576);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(12, 520);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(204, 29);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete Animal";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(166, 87);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 14;
            label1.Text = "Search ID: ";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(166, 110);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 15;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Location = new Point(222, 485);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(172, 29);
            btnSaveChanges.TabIndex = 16;
            btnSaveChanges.Text = "Save Changes";
            btnSaveChanges.UseVisualStyleBackColor = true;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(222, 520);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(172, 29);
            btnClear.TabIndex = 17;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // txtSearchID
            // 
            txtSearchID.Location = new Point(155, 145);
            txtSearchID.Name = "txtSearchID";
            txtSearchID.Size = new Size(125, 27);
            txtSearchID.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(txtSearchID);
            Controls.Add(btnClear);
            Controls.Add(btnSaveChanges);
            Controls.Add(btnSearch);
            Controls.Add(label1);
            Controls.Add(btnDelete);
            Controls.Add(dataGridView1);
            Controls.Add(textBox6);
            Controls.Add(btnAdd);
            Controls.Add(txtRecoveryScoreInput);
            Controls.Add(txtAgeInput);
            Controls.Add(txtSpeciesInput);
            Controls.Add(txtAnimalIDInput);
            Controls.Add(txtNameInput);
            Controls.Add(txtRecoveryScore);
            Controls.Add(txtAge);
            Controls.Add(txtSpecies);
            Controls.Add(txtName);
            Controls.Add(txtAnimalID);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Baobab Ridge Wildlife Rehabilitation";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtAnimalID;
        private Label txtName;
        private Label txtSpecies;
        private Label txtAge;
        private Label txtRecoveryScore;
        private TextBox txtNameInput;
        private TextBox txtAnimalIDInput;
        private TextBox txtSpeciesInput;
        private TextBox txtAgeInput;
        private TextBox txtRecoveryScoreInput;
        private Button btnAdd;
        private TextBox textBox6;
        private DataGridView dataGridView1;
        private Button btnDelete;
        private Label label1;
        private Button btnSearch;
        private Button btnSaveChanges;
        private Button btnClear;
        private TextBox txtSearchID;
    }
}
