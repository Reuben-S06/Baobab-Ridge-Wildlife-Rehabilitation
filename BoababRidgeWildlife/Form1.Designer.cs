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
            lblSummaryHeading = new Label();
            lblTotalAnimalsText = new Label();
            lblAverageAge = new Label();
            lblAverageAgeText = new Label();
            lblTotalAnimals = new Label();
            lblAverageScoreText = new Label();
            lblAverageScore = new Label();
            lblStatusHeading = new Label();
            lblCriticalText = new Label();
            lblSeriousText = new Label();
            lblStableText = new Label();
            lblRecoveringText = new Label();
            lblReleaseReadyText = new Label();
            lblCritical = new Label();
            lblSerious = new Label();
            lblStable = new Label();
            lblRecovering = new Label();
            lblReleaseReady = new Label();
            btnGenerateSummary = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(350, 9);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(439, 403);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(10, 390);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(178, 22);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete Animal";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(145, 65);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 14;
            label1.Text = "Search ID: ";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(145, 82);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(82, 22);
            btnSearch.TabIndex = 15;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Location = new Point(194, 364);
            btnSaveChanges.Margin = new Padding(3, 2, 3, 2);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(150, 22);
            btnSaveChanges.TabIndex = 16;
            btnSaveChanges.Text = "Save Changes";
            btnSaveChanges.UseVisualStyleBackColor = true;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(194, 390);
            btnClear.Margin = new Padding(3, 2, 3, 2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(150, 22);
            btnClear.TabIndex = 17;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // txtSearchID
            // 
            txtSearchID.Location = new Point(136, 109);
            txtSearchID.Margin = new Padding(3, 2, 3, 2);
            txtSearchID.Name = "txtSearchID";
            txtSearchID.Size = new Size(110, 23);
            txtSearchID.TabIndex = 18;
            // 
            // lblSummaryHeading
            // 
            lblSummaryHeading.AutoSize = true;
            lblSummaryHeading.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSummaryHeading.Location = new Point(10, 454);
            lblSummaryHeading.Name = "lblSummaryHeading";
            lblSummaryHeading.Size = new Size(116, 15);
            lblSummaryHeading.TabIndex = 19;
            lblSummaryHeading.Text = "SUMMARY REPORT";
            // 
            // lblTotalAnimalsText
            // 
            lblTotalAnimalsText.AutoSize = true;
            lblTotalAnimalsText.Location = new Point(10, 486);
            lblTotalAnimalsText.Name = "lblTotalAnimalsText";
            lblTotalAnimalsText.Size = new Size(80, 15);
            lblTotalAnimalsText.TabIndex = 20;
            lblTotalAnimalsText.Text = "Total animals:";
            // 
            // lblAverageAge
            // 
            lblAverageAge.AutoSize = true;
            lblAverageAge.Location = new Point(169, 524);
            lblAverageAge.Name = "lblAverageAge";
            lblAverageAge.Size = new Size(29, 15);
            lblAverageAge.TabIndex = 21;
            lblAverageAge.Text = "N/A";
            // 
            // lblAverageAgeText
            // 
            lblAverageAgeText.AutoSize = true;
            lblAverageAgeText.Location = new Point(12, 524);
            lblAverageAgeText.Name = "lblAverageAgeText";
            lblAverageAgeText.Size = new Size(113, 15);
            lblAverageAgeText.TabIndex = 22;
            lblAverageAgeText.Text = "Average age (years):";
            // 
            // lblTotalAnimals
            // 
            lblTotalAnimals.AutoSize = true;
            lblTotalAnimals.Location = new Point(169, 486);
            lblTotalAnimals.Name = "lblTotalAnimals";
            lblTotalAnimals.Size = new Size(13, 15);
            lblTotalAnimals.TabIndex = 23;
            lblTotalAnimals.Text = "0";
            // 
            // lblAverageScoreText
            // 
            lblAverageScoreText.AutoSize = true;
            lblAverageScoreText.Location = new Point(10, 562);
            lblAverageScoreText.Name = "lblAverageScoreText";
            lblAverageScoreText.Size = new Size(132, 15);
            lblAverageScoreText.TabIndex = 24;
            lblAverageScoreText.Text = "Average recovery score:";
            // 
            // lblAverageScore
            // 
            lblAverageScore.AutoSize = true;
            lblAverageScore.Location = new Point(169, 562);
            lblAverageScore.Name = "lblAverageScore";
            lblAverageScore.Size = new Size(29, 15);
            lblAverageScore.TabIndex = 25;
            lblAverageScore.Text = "N/A";
            // 
            // lblStatusHeading
            // 
            lblStatusHeading.AutoSize = true;
            lblStatusHeading.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatusHeading.Location = new Point(350, 454);
            lblStatusHeading.Name = "lblStatusHeading";
            lblStatusHeading.Size = new Size(111, 15);
            lblStatusHeading.TabIndex = 26;
            lblStatusHeading.Text = "Animals per status:";
            // 
            // lblCriticalText
            // 
            lblCriticalText.AutoSize = true;
            lblCriticalText.Location = new Point(350, 486);
            lblCriticalText.Name = "lblCriticalText";
            lblCriticalText.Size = new Size(47, 15);
            lblCriticalText.TabIndex = 27;
            lblCriticalText.Text = "Critical:";
            // 
            // lblSeriousText
            // 
            lblSeriousText.AutoSize = true;
            lblSeriousText.Location = new Point(350, 524);
            lblSeriousText.Name = "lblSeriousText";
            lblSeriousText.Size = new Size(48, 15);
            lblSeriousText.TabIndex = 28;
            lblSeriousText.Text = "Serious:";
            // 
            // lblStableText
            // 
            lblStableText.AutoSize = true;
            lblStableText.Location = new Point(350, 562);
            lblStableText.Name = "lblStableText";
            lblStableText.Size = new Size(42, 15);
            lblStableText.TabIndex = 29;
            lblStableText.Text = "Stable:";
            // 
            // lblRecoveringText
            // 
            lblRecoveringText.AutoSize = true;
            lblRecoveringText.Location = new Point(350, 603);
            lblRecoveringText.Name = "lblRecoveringText";
            lblRecoveringText.Size = new Size(69, 15);
            lblRecoveringText.TabIndex = 30;
            lblRecoveringText.Text = "Recovering:";
            // 
            // lblReleaseReadyText
            // 
            lblReleaseReadyText.AutoSize = true;
            lblReleaseReadyText.Location = new Point(350, 641);
            lblReleaseReadyText.Name = "lblReleaseReadyText";
            lblReleaseReadyText.Size = new Size(86, 15);
            lblReleaseReadyText.TabIndex = 31;
            lblReleaseReadyText.Text = "Release-Ready:";
            // 
            // lblCritical
            // 
            lblCritical.AutoSize = true;
            lblCritical.Location = new Point(498, 486);
            lblCritical.Name = "lblCritical";
            lblCritical.Size = new Size(13, 15);
            lblCritical.TabIndex = 32;
            lblCritical.Text = "0";
            // 
            // lblSerious
            // 
            lblSerious.AutoSize = true;
            lblSerious.Location = new Point(498, 524);
            lblSerious.Name = "lblSerious";
            lblSerious.Size = new Size(13, 15);
            lblSerious.TabIndex = 33;
            lblSerious.Text = "0";
            // 
            // lblStable
            // 
            lblStable.AutoSize = true;
            lblStable.Location = new Point(498, 562);
            lblStable.Name = "lblStable";
            lblStable.Size = new Size(13, 15);
            lblStable.TabIndex = 34;
            lblStable.Text = "0";
            // 
            // lblRecovering
            // 
            lblRecovering.AutoSize = true;
            lblRecovering.Location = new Point(498, 603);
            lblRecovering.Name = "lblRecovering";
            lblRecovering.Size = new Size(13, 15);
            lblRecovering.TabIndex = 35;
            lblRecovering.Text = "0";
            // 
            // lblReleaseReady
            // 
            lblReleaseReady.AutoSize = true;
            lblReleaseReady.Location = new Point(498, 641);
            lblReleaseReady.Name = "lblReleaseReady";
            lblReleaseReady.Size = new Size(13, 15);
            lblReleaseReady.TabIndex = 36;
            lblReleaseReady.Text = "0";
            // 
            // btnGenerateSummary
            // 
            btnGenerateSummary.Location = new Point(10, 634);
            btnGenerateSummary.Name = "btnGenerateSummary";
            btnGenerateSummary.Size = new Size(169, 28);
            btnGenerateSummary.TabIndex = 37;
            btnGenerateSummary.Text = "Generate Summary";
            btnGenerateSummary.UseVisualStyleBackColor = true;
            btnGenerateSummary.Click += btnGenerateSummary_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 675);
            Controls.Add(btnGenerateSummary);
            Controls.Add(lblReleaseReady);
            Controls.Add(lblRecovering);
            Controls.Add(lblStable);
            Controls.Add(lblSerious);
            Controls.Add(lblCritical);
            Controls.Add(lblReleaseReadyText);
            Controls.Add(lblRecoveringText);
            Controls.Add(lblStableText);
            Controls.Add(lblSeriousText);
            Controls.Add(lblCriticalText);
            Controls.Add(lblStatusHeading);
            Controls.Add(lblAverageScore);
            Controls.Add(lblAverageScoreText);
            Controls.Add(lblTotalAnimals);
            Controls.Add(lblAverageAgeText);
            Controls.Add(lblAverageAge);
            Controls.Add(lblTotalAnimalsText);
            Controls.Add(lblSummaryHeading);
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
        private Label lblSummaryHeading;
        private Label lblTotalAnimalsText;
        private Label lblAverageAge;
        private Label lblAverageAgeText;
        private Label lblTotalAnimals;
        private Label lblAverageScoreText;
        private Label lblAverageScore;
        private Label lblStatusHeading;
        private Label lblCriticalText;
        private Label lblSeriousText;
        private Label lblStableText;
        private Label lblRecoveringText;
        private Label lblReleaseReadyText;
        private Label lblCritical;
        private Label lblSerious;
        private Label lblStable;
        private Label lblRecovering;
        private Label lblReleaseReady;
        private Button btnGenerateSummary;
    }
}
