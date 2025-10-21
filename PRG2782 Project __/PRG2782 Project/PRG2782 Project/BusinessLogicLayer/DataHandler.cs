using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG2782_Project.BusinessLogicLayer
{
    
    internal class DataHandler
    {
        public DataHandler() { }


        // This method gives a superhero a rank and threat level based on their exam score
        public void RankingSystem(Superheroes superhero)
        {
            if (superhero.HeroExamScore >= 81 && superhero.HeroExamScore <= 100)
            {
                superhero.Rank = "S-Rank";
                superhero.ThreatLevel = "Finals Week";

            }
            else if (superhero.HeroExamScore >= 61 && superhero.HeroExamScore <= 80)
            {
                superhero.Rank = "A-Rank";
                superhero.ThreatLevel = "Midterm Madness";
            }
            else if (superhero.HeroExamScore >= 41 && superhero.HeroExamScore <= 600)
            {
                superhero.Rank = "B-Rank";
                superhero.ThreatLevel = "Group Project Wrong";
            }
            else if (superhero.HeroExamScore >= 0 && superhero.HeroExamScore <= 40)
            {
                superhero.Rank = "C-Rank";
                superhero.ThreatLevel = "Pop Quiz";
            }

        }

    }
}
