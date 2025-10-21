using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace One_Kick_Academy_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadHeroes();

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var hero = new Superhero
            {
                HeroID = txtHeroID.Text.Trim(),
                Name = txtName.Text.Trim(),
                Age = int.Parse(txtAge.Text),
                Superpower = txtSuperpower.Text.Trim(),
                ExamScore = int.Parse(txtExamScore.Text)
            };

            File.AppendAllText("superheroes.txt", hero + Environment.NewLine);
            LoadHeroes();
        }
        private void LoadHeroes()
        {
            dgvHeroes.Rows.Clear();

            if (dgvHeroes.Columns.Count == 0)
            {
                dgvHeroes.Columns.Add("HeroID", "Hero ID");
                dgvHeroes.Columns.Add("Name", "Name");
                dgvHeroes.Columns.Add("Age", "Age");
                dgvHeroes.Columns.Add("Superpower", "Superpower");
                dgvHeroes.Columns.Add("ExamScore", "Exam Score");
                dgvHeroes.Columns.Add("Rank", "Rank");
                dgvHeroes.Columns.Add("ThreatLevel", "Threat Level");
            }

            if (!File.Exists("superheroes.txt")) return;

            foreach (var line in File.ReadAllLines("superheroes.txt"))
            {
                var parts = line.Split('|');
                if (parts.Length == 7)
                {
                    dgvHeroes.Rows.Add(parts);
                }
            }
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var lines = File.ReadAllLines("superheroes.txt").ToList();
            var updated = new Superhero
            {
                HeroID = txtHeroID.Text.Trim(),
                Name = txtName.Text.Trim(),
                Age = int.Parse(txtAge.Text),
                Superpower = txtSuperpower.Text.Trim(),
                ExamScore = int.Parse(txtExamScore.Text)
            };

            for (int i = 0; i < lines.Count; i++)
            {
                if (lines[i].StartsWith(updated.HeroID + "|"))
                {
                    lines[i] = updated.ToString();
                    break;
                }
            }

            File.WriteAllLines("superheroes.txt", lines);
            LoadHeroes();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvHeroes.SelectedRows.Count == 0) return;

            var idToDelete = dgvHeroes.SelectedRows[0].Cells[0].Value.ToString();
            var lines = File.ReadAllLines("superheroes.txt")
                            .Where(line => !line.StartsWith(idToDelete + "|"))
                            .ToList();

            File.WriteAllLines("superheroes.txt", lines);
            LoadHeroes();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            if (!File.Exists("superheroes.txt"))
            {
                MessageBox.Show("No superhero data found.");
                return;
            }

            var lines = File.ReadAllLines("superheroes.txt");

            var heroes = lines.Select(line =>
            {
                var parts = line.Split('|');
                return new Superhero
                {
                    HeroID = parts[0],
                    Name = parts[1],
                    Age = int.Parse(parts[2]),
                    Superpower = parts[3],
                    ExamScore = int.Parse(parts[4])
                };
            }).ToList();

            int total = heroes.Count;
            double avgAge = heroes.Average(h => h.Age);
            double avgScore = heroes.Average(h => h.ExamScore);

            var rankGroups = heroes.GroupBy(h => h.Rank)
                                   .ToDictionary(g => g.Key, g => g.Count());

            // Fallback to 0 if rank key is not found
            int s = rankGroups.ContainsKey("S") ? rankGroups["S"] : 0;
            int a = rankGroups.ContainsKey("A") ? rankGroups["A"] : 0;
            int b = rankGroups.ContainsKey("B") ? rankGroups["B"] : 0;
            int c = rankGroups.ContainsKey("C") ? rankGroups["C"] : 0;

            string report = "Total Superheroes: " + total + "\n" +
                            "Average Age: " + avgAge.ToString("F1") + "\n" +
                            "Average Exam Score: " + avgScore.ToString("F1") + "\n" +
                            "S-Rank: " + s + "\n" +
                            "A-Rank: " + a + "\n" +
                            "B-Rank: " + b + "\n" +
                            "C-Rank: " + c;

            File.WriteAllText("summary.txt", report);

           
            System.Diagnostics.Process.Start("notepad.exe", "summary.txt");

            lblSummaryOutput.Text = report;
        }

        private void dgvHeroes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
