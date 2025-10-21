using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG2782_Project.DataLayer
{
    internal class FileHandler
    {

        public FileHandler() { }


        // This is the path where Superheroes.txt  is stored we made it 
        public string filePath = @"C:\Users\Mapula\OneDrive\Documents\PRG282\PRG2782 Project\PRG2782 Project\Superheroes.txt";


        // This method use streamwriter to writes a superhero's details to the text file.It does not overwrite if the code already exists on the textfile
        public void write(Superheroes hero)
        {

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(hero.ToString());

            }
            
        }

        // This method reads all superheroes from the text file
        public List<string> read()
        {
            List<string> receivedData = new List<string>();
            // Check if the file exists before reading
            if (File.Exists(filePath))
            {
                
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string txt;

                    // Read each line until the end of the file
                    while ((txt = reader.ReadLine()) != null)
                    {

                        receivedData.Add(txt);

                    }

                }
                return receivedData;

            }
            else
            {
                return receivedData;
            }

            Console.ReadLine();

        }

        // This method converts a list of text lines into a list of Superheroes objects
        public List<Superheroes> format(List<string> lines)
        {
            // List to store all heroes
            List<Superheroes> heroes = new List<Superheroes>();

            // The foreach loop loops through each line in the list
            foreach (string line in lines)
            {
                // Each line is split into items and each item is split using '|' to separate the values
                string[] items = line.Split('|');

                // This if statement makes sure that each line in the list/textfile has enough items to form a valid superhero
                if (items.Length >= 5)
                {
                    Superheroes h = new Superheroes
                    {
                        HeroId = int.Parse(items[0].Trim()),
                        Age = int.Parse(items[1].Trim()),
                        Name = items[2].Trim(),
                        Superpower = items[3].Trim(),
                        HeroExamScore = double.Parse(items[4].Trim())

                    };

                    //we then add the specific line of superhero details onto the heroes list to store temporarily
                    heroes.Add(h);
                }


            }
            return heroes;

        }

        internal object write()
        {
            throw new NotImplementedException();
        }

        // This method is used to update the Superheroes.txt with a new list of superheroes
        public void UpdateFile(List<Superheroes> heroesList)
        {
            using (StreamWriter writer = new StreamWriter(filePath)) 
            {
                foreach (Superheroes hero in heroesList)
                {
                    writer.Write(hero.ToString());
                }
            }
        }

    }
}

