namespace One_Kick_Academy_Management_System
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
            this.txtHeroID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtSuperpower = new System.Windows.Forms.TextBox();
            this.txtExamScore = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.dgvHeroes = new System.Windows.Forms.DataGridView();
            this.lblSummaryOutput = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHeroes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtHeroID
            // 
            this.txtHeroID.Location = new System.Drawing.Point(136, 89);
            this.txtHeroID.Name = "txtHeroID";
            this.txtHeroID.Size = new System.Drawing.Size(148, 22);
            this.txtHeroID.TabIndex = 0;
            this.txtHeroID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(136, 129);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(148, 22);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(136, 170);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(148, 22);
            this.txtAge.TabIndex = 2;
            // 
            // txtSuperpower
            // 
            this.txtSuperpower.Location = new System.Drawing.Point(136, 214);
            this.txtSuperpower.Name = "txtSuperpower";
            this.txtSuperpower.Size = new System.Drawing.Size(148, 22);
            this.txtSuperpower.TabIndex = 3;
            // 
            // txtExamScore
            // 
            this.txtExamScore.Location = new System.Drawing.Point(136, 261);
            this.txtExamScore.Name = "txtExamScore";
            this.txtExamScore.Size = new System.Drawing.Size(148, 22);
            this.txtExamScore.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(31, 315);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(148, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(31, 362);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(148, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(31, 414);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(148, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(31, 468);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(148, 23);
            this.btnGenerateReport.TabIndex = 8;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // dgvHeroes
            // 
            this.dgvHeroes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHeroes.Location = new System.Drawing.Point(363, 95);
            this.dgvHeroes.Name = "dgvHeroes";
            this.dgvHeroes.RowHeadersWidth = 51;
            this.dgvHeroes.RowTemplate.Height = 24;
            this.dgvHeroes.Size = new System.Drawing.Size(733, 193);
            this.dgvHeroes.TabIndex = 9;
            this.dgvHeroes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHeroes_CellContentClick);
            // 
            // lblSummaryOutput
            // 
            this.lblSummaryOutput.AutoSize = true;
            this.lblSummaryOutput.Location = new System.Drawing.Point(360, 322);
            this.lblSummaryOutput.Name = "lblSummaryOutput";
            this.lblSummaryOutput.Size = new System.Drawing.Size(96, 16);
            this.lblSummaryOutput.TabIndex = 10;
            this.lblSummaryOutput.Text = "View Summary";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Hero ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Age:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Superpower:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Exam Score";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.label6.Location = new System.Drawing.Point(441, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "One Kick Hereos Academy";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 503);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSummaryOutput);
            this.Controls.Add(this.dgvHeroes);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtExamScore);
            this.Controls.Add(this.txtSuperpower);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtHeroID);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHeroes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHeroID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtSuperpower;
        private System.Windows.Forms.TextBox txtExamScore;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.DataGridView dgvHeroes;
        private System.Windows.Forms.Label lblSummaryOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

