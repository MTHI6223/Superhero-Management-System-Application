using PRG2782_Project.BusinessLogicLayer;
using PRG2782_Project.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PRG2782_Project
{
    public partial class Form1 : Form
    {

        //The filehandler and datahandler objects are made so that we can get the file and business logic methods.we wrote it here instead of in a method so that we do not need to rewrite the same code multiple times.
        FileHandler fileHandler = new FileHandler();
        DataHandler dataHandler=new DataHandler();

        // This List stores all superhero objects and we wrote it here instead of in a method so that we do not need to rewrite the same code multiple times.
        List<Superheroes> heroesList = new List<Superheroes>();

        public Form1()
        {
            InitializeComponent();
        }

        // When a user clicks the add button a new superhero will be added to the list, saved to file and the form
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                //Check if all of the textboxes on the form are filled in
                if (string.IsNullOrWhiteSpace(heroIdtextBox.Text) ||
                    string.IsNullOrWhiteSpace(heroNametextBox.Text) ||
                    string.IsNullOrWhiteSpace(agetextBox.Text) ||
                    string.IsNullOrWhiteSpace(superpowertextBox.Text) ||
                    string.IsNullOrWhiteSpace(examScoretextBox.Text))
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                // Ensures that only valid data is typed into the Hero ID textbox
                if (!int.TryParse(heroIdtextBox.Text, out int heroId))
                {
                    MessageBox.Show("Hero ID must be a valid number.");
                    return;
                }

                // Ensures that only valid data is typed into the age textbox
                if (!int.TryParse(agetextBox.Text, out int age))
                {
                    MessageBox.Show("Age must be a valid number.");
                    return;
                }

                // Ensures that only valid data is typed into the Exam Score textbox
                if (!double.TryParse(examScoretextBox.Text, out double examScore))
                {
                    MessageBox.Show("Exam score must be a valid number.");
                    return;
                }

                // Ensures that a user cannot enter a number that is negative or greater than 100 
                if (examScore < 0 || examScore > 100)
                {
                    MessageBox.Show("Exam score must be between 0 and 100.");
                    return;
                }

                Superheroes hero = new Superheroes()
                {
                    HeroId = heroId,
                    Name = heroNametextBox.Text,
                    Age = age,
                    Superpower = superpowertextBox.Text,
                    HeroExamScore = examScore
                };

                // we are calling the datahandler method ranking system so that we can pass the data that the user just entered in then the Rank and Threat Level will be calculated automatically
                dataHandler.RankingSystem(hero);

                heroesList.Add(hero);

                // We clear the form so that no data shows then add the data from the heroes list 
                dataGridViewSuperheroes.DataSource = null;
                dataGridViewSuperheroes.DataSource = heroesList;

                fileHandler.write(hero);

                MessageBox.Show("Superhero added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        //This method is used to delete the chosen superhero from the form and file then update both the form and file
        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridViewSuperheroes.SelectedRows.Count > 0)
            {
                // Get the selected hero’s ID
                int selectedId = Convert.ToInt32(dataGridViewSuperheroes.SelectedRows[0].Cells["HeroId"].Value);

                // Find the superhero in the list
                Superheroes heroToDelete = heroesList.FirstOrDefault(h => h.HeroId == selectedId);

                if (heroToDelete != null)
                {
                    // Remove from list
                    heroesList.Remove(heroToDelete);

                    // Call the updatefile method so that the latest data is the one that shows on the form
                    fileHandler.UpdateFile(heroesList);

                    dataGridViewSuperheroes.DataSource = null;
                    dataGridViewSuperheroes.DataSource = heroesList;

                    MessageBox.Show("Superhero deleted successfully!");
                }
                else
                {
                    MessageBox.Show("Superhero not found in the list.");
                }
            }
            else
            {
                MessageBox.Show("Please select a superhero to delete.");
            }
        }

        //This method is used to show all of the superheroes from the file into the form
        private void viewSuperhero_Click(object sender, EventArgs e)
        {
            dataGridViewSuperheroes.DataSource = fileHandler.format(fileHandler.read());
        }
        private void dataGridViewSuperheroes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the chosen superhero
                Superheroes selectedHero = heroesList[e.RowIndex];

                // Fill in the form fields
                heroIdtextBox.Text = selectedHero.HeroId.ToString();
                heroNametextBox.Text = selectedHero.Name;
                agetextBox.Text = selectedHero.Age.ToString();
                superpowertextBox.Text = selectedHero.Superpower;
                examScoretextBox.Text = selectedHero.HeroExamScore.ToString();
            }
        }

        // This button updates the chosen superhero’s details
       private void updateSuperhero_Click(object sender, EventArgs e)
        {
            if (dataGridViewSuperheroes.SelectedRows.Count > 0)
            {
                int selectedId = Convert.ToInt32(dataGridViewSuperheroes.SelectedRows[0].Cells["HeroId"].Value);
                Superheroes heroToUpdate = heroesList.FirstOrDefault(h => h.HeroId == selectedId);

                if (heroToUpdate != null)
                {
                    // Update the superhero's properties with the new values
                    heroToUpdate.HeroId = int.Parse(heroIdtextBox.Text);
                    heroToUpdate.Name = heroNametextBox.Text;
                    heroToUpdate.Age = int.Parse(agetextBox.Text);
                    heroToUpdate.Superpower = superpowertextBox.Text;
                    heroToUpdate.HeroExamScore = double.Parse(examScoretextBox.Text);

                    // Recalculate Rank and Threat Level
                    dataHandler.RankingSystem(heroToUpdate);

                    // Update the file
                    fileHandler.UpdateFile(heroesList);

                    // Prevent duplication or stale data in the DataGridView
                    dataGridViewSuperheroes.DataSource = null;

                    // Use ToList() to create a fresh binding list so the DataGridView refreshes cleanly
                    dataGridViewSuperheroes.DataSource = heroesList.ToList();

                    // Ensure DataGridView updates properly without errors or duplicates
                    dataGridViewSuperheroes.Refresh();

                    MessageBox.Show("Superhero updated successfully! The DataGridView displays updated information without errors or duplication.");
                }
                else
                {
                    MessageBox.Show("Error: Selected superhero not found.");
                }
            }
            else
            {
                MessageBox.Show("Please select a superhero to update.");
            }
        }

        private void summaryReport_Click(object sender, EventArgs e)
        {
            // Check if the file exists
            if (!File.Exists(fileHandler.filePath))
            {
                MessageBox.Show("No superhero data found.");
                return;
            }

            // Read all lines from the file
            var lines = File.ReadAllLines(fileHandler.filePath);

            // Convert lines to Superheroes objects
            var heroes = lines.Select(line =>
            {
                var parts = line.Split('|');
                try
                {
                    return new Superheroes
                    {
                        HeroId = int.Parse(parts[0].Trim()),
                        Age = int.Parse(parts[1].Trim()),
                        Name = parts[2].Trim(),
                        Superpower = parts[3].Trim(),
                        HeroExamScore = double.Parse(parts[4].Trim()),
                        Rank = parts.Length > 5 ? parts[5].Trim() : "",
                        ThreatLevel = parts.Length > 6 ? parts[6].Trim() : ""
                    };
                }
                catch
                {
                    // Skip invalid lines
                    return null;
                }
            }).Where(h => h != null).ToList();

            if (heroes.Count == 0)
            {
                MessageBox.Show("No valid superhero data found.");
                return;
            }

            // Calculate summary statistics
            int total = heroes.Count;
            double avgAge = heroes.Average(h => h.Age);
            double avgScore = heroes.Average(h => h.HeroExamScore);

            // Count heroes per rank
            var rankGroups = heroes.GroupBy(h => h.Rank)
                                   .ToDictionary(g => g.Key, g => g.Count());

            int s = rankGroups.ContainsKey("S-Rank") ? rankGroups["S-Rank"] : 0;
            int a = rankGroups.ContainsKey("A-Rank") ? rankGroups["A-Rank"] : 0;
            int b = rankGroups.ContainsKey("B-Rank") ? rankGroups["B-Rank"] : 0;
            int c = rankGroups.ContainsKey("C-Rank") ? rankGroups["C-Rank"] : 0;

            // Build the report string
            string report = "Total Superheroes: " + total + "\n" +
                            "Average Age: " + avgAge.ToString("F1") + "\n" +
                            "Average Exam Score: " + avgScore.ToString("F1") + "\n" +
                            "S-Rank: " + s + "\n" +
                            "A-Rank: " + a + "\n" +
                            "B-Rank: " + b + "\n" +
                            "C-Rank: " + c;

            // Display in the form label
            lblSummaryOutput.Text = report;

            // Save to summary.txt
            string summaryPath = @"C:\Users\Mapula\OneDrive\Documents\PRG282\PRG2782 Project\PRG2782 Project\Summary.txt";
            File.WriteAllText(summaryPath, report);
        
        }
    }
}
