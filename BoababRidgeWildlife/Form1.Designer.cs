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
            SuspendLayout();
            // 
            // txtAnimalID
            // 
            txtAnimalID.AutoSize = true;
            txtAnimalID.Location = new Point(12, 65);
            txtAnimalID.Name = "txtAnimalID";
            txtAnimalID.Size = new Size(59, 15);
            txtAnimalID.TabIndex = 0;
            txtAnimalID.Text = "Animal ID";
            // 
            // txtName
            // 
            txtName.AutoSize = true;
            txtName.Location = new Point(12, 122);
            txtName.Name = "txtName";
            txtName.Size = new Size(39, 15);
            txtName.TabIndex = 1;
            txtName.Text = "Name";
            // 
            // txtSpecies
            // 
            txtSpecies.AutoSize = true;
            txtSpecies.Location = new Point(12, 178);
            txtSpecies.Name = "txtSpecies";
            txtSpecies.Size = new Size(46, 15);
            txtSpecies.TabIndex = 2;
            txtSpecies.Text = "Species";
            // 
            // txtAge
            // 
            txtAge.AutoSize = true;
            txtAge.Location = new Point(12, 241);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(63, 15);
            txtAge.TabIndex = 3;
            txtAge.Text = "Age(years)";
            // 
            // txtRecoveryScore
            // 
            txtRecoveryScore.AutoSize = true;
            txtRecoveryScore.Location = new Point(12, 307);
            txtRecoveryScore.Name = "txtRecoveryScore";
            txtRecoveryScore.Size = new Size(87, 15);
            txtRecoveryScore.TabIndex = 4;
            txtRecoveryScore.Text = "Recovery Score";
            // 
            // txtNameInput
            // 
            txtNameInput.Location = new Point(12, 140);
            txtNameInput.Name = "txtNameInput";
            txtNameInput.Size = new Size(100, 23);
            txtNameInput.TabIndex = 5;
            // 
            // txtAnimalIDInput
            // 
            txtAnimalIDInput.Location = new Point(12, 83);
            txtAnimalIDInput.Name = "txtAnimalIDInput";
            txtAnimalIDInput.Size = new Size(100, 23);
            txtAnimalIDInput.TabIndex = 6;
            // 
            // txtSpeciesInput
            // 
            txtSpeciesInput.Location = new Point(12, 196);
            txtSpeciesInput.Name = "txtSpeciesInput";
            txtSpeciesInput.Size = new Size(100, 23);
            txtSpeciesInput.TabIndex = 7;
            // 
            // txtAgeInput
            // 
            txtAgeInput.Location = new Point(12, 259);
            txtAgeInput.Name = "txtAgeInput";
            txtAgeInput.Size = new Size(100, 23);
            txtAgeInput.TabIndex = 8;
            // 
            // txtRecoveryScoreInput
            // 
            txtRecoveryScoreInput.Location = new Point(12, 325);
            txtRecoveryScoreInput.Name = "txtRecoveryScoreInput";
            txtRecoveryScoreInput.Size = new Size(100, 23);
            txtRecoveryScoreInput.TabIndex = 9;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 364);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(177, 23);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add Animal";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(12, 12);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(200, 23);
            textBox6.TabIndex = 11;
            textBox6.Text = "Baobab Ridge Wildlife Rehabilitation";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "Form1";
            Text = "Baobab Ridge Wildlife Rehabilitation";
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
    }
}
