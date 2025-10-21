using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG2782_Project
{
    internal class Superheroes
    {
        //These fields were made to store the superhero's information
        int heroId, age;
        string name, superpower, threatLevel, rank;
        double heroExamScore;

        public Superheroes()
        {
        }


        //This constructor enables the user to pass the data that they have entered into the fields for the specific hero 
        public Superheroes(int heroId, int age, string name, string superpower, string threatLevel, string rank, double heroExamScore)
        {
            this.HeroId = heroId;
            this.Age = age;
            this.Name = name;
            this.Superpower = superpower;
            this.ThreatLevel = threatLevel;
            this.Rank = rank;
            this.HeroExamScore = heroExamScore;
        }

        //These properties allow us to access the fields while making sure that they are encapsulated
        public int HeroId { get => heroId; set => heroId = value; }
        public int Age { get => age; set => age = value; }
        public string Name { get => name; set => name = value; }
        public string Superpower { get => superpower; set => superpower = value; }
        public string ThreatLevel { get => threatLevel; set => threatLevel = value; }
        public string Rank { get => rank; set => rank = value; }
        public double HeroExamScore { get => heroExamScore; set => heroExamScore = value; }


        //This to String method determines the format that the data is going to be displayed in the Superheroes.txt and other methods that use it
        public override string ToString()
        {
            return "   Hero ID: " + HeroId + "  |Age: " + Age + " |Name: " + Name + " |Superpower: " + Superpower + "  |Hero Exam Score: " + HeroExamScore + "  |Rank " + Rank + "  |Threat Level: " + ThreatLevel;

        }




    }
}
