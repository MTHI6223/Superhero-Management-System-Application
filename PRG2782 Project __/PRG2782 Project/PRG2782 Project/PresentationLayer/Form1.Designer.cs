namespace PRG2782_Project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addSuperhero = new System.Windows.Forms.Button();
            this.viewSuperhero = new System.Windows.Forms.Button();
            this.updateSuperhero = new System.Windows.Forms.Button();
            this.deleteSuperhero = new System.Windows.Forms.Button();
            this.summaryReport = new System.Windows.Forms.Button();
            this.dataGridViewSuperheroes = new System.Windows.Forms.DataGridView();
            this.heroID = new System.Windows.Forms.Button();
            this.age = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Button();
            this.superPower = new System.Windows.Forms.Button();
            this.examScore = new System.Windows.Forms.Button();
            this.heroIdtextBox = new System.Windows.Forms.TextBox();
            this.heroNametextBox = new System.Windows.Forms.TextBox();
            this.agetextBox = new System.Windows.Forms.TextBox();
            this.superpowertextBox = new System.Windows.Forms.TextBox();
            this.examScoretextBox = new System.Windows.Forms.TextBox();
            this.lblSummaryOutput = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuperheroes)).BeginInit();
            this.SuspendLayout();
            // 
            // addSuperhero
            // 
            this.addSuperhero.Location = new System.Drawing.Point(0, 279);
            this.addSuperhero.Name = "addSuperhero";
            this.addSuperhero.Size = new System.Drawing.Size(129, 23);
            this.addSuperhero.TabIndex = 0;
            this.addSuperhero.Text = "Add Superhero";
            this.addSuperhero.UseVisualStyleBackColor = true;
            this.addSuperhero.Click += new System.EventHandler(this.button1_Click);
            // 
            // viewSuperhero
            // 
            this.viewSuperhero.Location = new System.Drawing.Point(0, 340);
            this.viewSuperhero.Name = "viewSuperhero";
            this.viewSuperhero.Size = new System.Drawing.Size(129, 23);
            this.viewSuperhero.TabIndex = 1;
            this.viewSuperhero.Text = "View Superhero";
            this.viewSuperhero.UseVisualStyleBackColor = true;
            this.viewSuperhero.Click += new System.EventHandler(this.viewSuperhero_Click);
            // 
            // updateSuperhero
            // 
            this.updateSuperhero.Location = new System.Drawing.Point(147, 279);
            this.updateSuperhero.Name = "updateSuperhero";
            this.updateSuperhero.Size = new System.Drawing.Size(129, 23);
            this.updateSuperhero.TabIndex = 2;
            this.updateSuperhero.Text = "Update Superhero";
            this.updateSuperhero.UseVisualStyleBackColor = true;
            this.updateSuperhero.Click += new System.EventHandler(this.updateSuperhero_Click);
            // 
            // deleteSuperhero
            // 
            this.deleteSuperhero.Location = new System.Drawing.Point(147, 340);
            this.deleteSuperhero.Name = "deleteSuperhero";
            this.deleteSuperhero.Size = new System.Drawing.Size(129, 23);
            this.deleteSuperhero.TabIndex = 3;
            this.deleteSuperhero.Text = "Delete Superhero";
            this.deleteSuperhero.UseVisualStyleBackColor = true;
            this.deleteSuperhero.Click += new System.EventHandler(this.button4_Click);
            // 
            // summaryReport
            // 
            this.summaryReport.Location = new System.Drawing.Point(12, 397);
            this.summaryReport.Name = "summaryReport";
            this.summaryReport.Size = new System.Drawing.Size(129, 23);
            this.summaryReport.TabIndex = 4;
            this.summaryReport.Text = "Summary Report";
            this.summaryReport.UseVisualStyleBackColor = true;
            this.summaryReport.Click += new System.EventHandler(this.summaryReport_Click);
            // 
            // dataGridViewSuperheroes
            // 
            this.dataGridViewSuperheroes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSuperheroes.Location = new System.Drawing.Point(282, 12);
            this.dataGridViewSuperheroes.Name = "dataGridViewSuperheroes";
            this.dataGridViewSuperheroes.Size = new System.Drawing.Size(685, 307);
            this.dataGridViewSuperheroes.TabIndex = 6;
            // 
            // heroID
            // 
            this.heroID.Location = new System.Drawing.Point(0, 26);
            this.heroID.Name = "heroID";
            this.heroID.Size = new System.Drawing.Size(75, 23);
            this.heroID.TabIndex = 7;
            this.heroID.Text = "Hero ID:";
            this.heroID.UseVisualStyleBackColor = true;
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(0, 110);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(75, 23);
            this.age.TabIndex = 8;
            this.age.Text = "Age:";
            this.age.UseVisualStyleBackColor = true;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(0, 67);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(75, 23);
            this.name.TabIndex = 9;
            this.name.Text = "Name:";
            this.name.UseVisualStyleBackColor = true;
            // 
            // superPower
            // 
            this.superPower.Location = new System.Drawing.Point(0, 154);
            this.superPower.Name = "superPower";
            this.superPower.Size = new System.Drawing.Size(75, 23);
            this.superPower.TabIndex = 10;
            this.superPower.Text = "Superpower:";
            this.superPower.UseVisualStyleBackColor = true;
            // 
            // examScore
            // 
            this.examScore.Location = new System.Drawing.Point(0, 207);
            this.examScore.Name = "examScore";
            this.examScore.Size = new System.Drawing.Size(75, 23);
            this.examScore.TabIndex = 11;
            this.examScore.Text = "Exam Score:";
            this.examScore.UseVisualStyleBackColor = true;
            // 
            // heroIdtextBox
            // 
            this.heroIdtextBox.Location = new System.Drawing.Point(125, 26);
            this.heroIdtextBox.Name = "heroIdtextBox";
            this.heroIdtextBox.Size = new System.Drawing.Size(100, 20);
            this.heroIdtextBox.TabIndex = 12;
            // 
            // heroNametextBox
            // 
            this.heroNametextBox.Location = new System.Drawing.Point(125, 69);
            this.heroNametextBox.Name = "heroNametextBox";
            this.heroNametextBox.Size = new System.Drawing.Size(100, 20);
            this.heroNametextBox.TabIndex = 13;
            // 
            // agetextBox
            // 
            this.agetextBox.Location = new System.Drawing.Point(125, 113);
            this.agetextBox.Name = "agetextBox";
            this.agetextBox.Size = new System.Drawing.Size(100, 20);
            this.agetextBox.TabIndex = 14;
            // 
            // superpowertextBox
            // 
            this.superpowertextBox.Location = new System.Drawing.Point(125, 154);
            this.superpowertextBox.Name = "superpowertextBox";
            this.superpowertextBox.Size = new System.Drawing.Size(100, 20);
            this.superpowertextBox.TabIndex = 15;
            // 
            // examScoretextBox
            // 
            this.examScoretextBox.Location = new System.Drawing.Point(125, 210);
            this.examScoretextBox.Name = "examScoretextBox";
            this.examScoretextBox.Size = new System.Drawing.Size(100, 20);
            this.examScoretextBox.TabIndex = 16;
            // 
            // lblSummaryOutput
            // 
            this.lblSummaryOutput.AutoSize = true;
            this.lblSummaryOutput.Location = new System.Drawing.Point(405, 345);
            this.lblSummaryOutput.Name = "lblSummaryOutput";
            this.lblSummaryOutput.Size = new System.Drawing.Size(76, 13);
            this.lblSummaryOutput.TabIndex = 17;
            this.lblSummaryOutput.Text = "View Summary";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 450);
            this.Controls.Add(this.lblSummaryOutput);
            this.Controls.Add(this.examScoretextBox);
            this.Controls.Add(this.superpowertextBox);
            this.Controls.Add(this.agetextBox);
            this.Controls.Add(this.heroNametextBox);
            this.Controls.Add(this.heroIdtextBox);
            this.Controls.Add(this.examScore);
            this.Controls.Add(this.superPower);
            this.Controls.Add(this.name);
            this.Controls.Add(this.age);
            this.Controls.Add(this.heroID);
            this.Controls.Add(this.dataGridViewSuperheroes);
            this.Controls.Add(this.summaryReport);
            this.Controls.Add(this.deleteSuperhero);
            this.Controls.Add(this.updateSuperhero);
            this.Controls.Add(this.viewSuperhero);
            this.Controls.Add(this.addSuperhero);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuperheroes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addSuperhero;
        private System.Windows.Forms.Button viewSuperhero;
        private System.Windows.Forms.Button updateSuperhero;
        private System.Windows.Forms.Button deleteSuperhero;
        private System.Windows.Forms.Button summaryReport;
        private System.Windows.Forms.DataGridView dataGridViewSuperheroes;
        private System.Windows.Forms.Button heroID;
        private System.Windows.Forms.Button age;
        private System.Windows.Forms.Button name;
        private System.Windows.Forms.Button superPower;
        private System.Windows.Forms.Button examScore;
        private System.Windows.Forms.TextBox heroIdtextBox;
        private System.Windows.Forms.TextBox heroNametextBox;
        private System.Windows.Forms.TextBox agetextBox;
        private System.Windows.Forms.TextBox superpowertextBox;
        private System.Windows.Forms.TextBox examScoretextBox;
        private System.Windows.Forms.Label lblSummaryOutput;
    }
}

