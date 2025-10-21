using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One_Kick_Academy_Management_System
{
    public class Superhero
    {
        public string HeroID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Superpower { get; set; }
        public int ExamScore { get; set; }
        public string Rank => CalculateRank();
        public string ThreatLevel => CalculateThreatLevel();

        private string CalculateRank()
        {
            if (ExamScore >= 81) return "S";
            else if (ExamScore >= 61) return "A";
            else if (ExamScore >= 41) return "B";
            else return "C";
        }

        private string CalculateThreatLevel()
        {
            if (Rank == "S")
                return "Finals Week";
            else if (Rank == "A")
                return "Midterm Madness";
            else if (Rank == "B")
                return "Group Project Gone Wrong";
            else
                return "Pop Quiz";
        }

        public override string ToString() =>
            $"{HeroID}|{Name}|{Age}|{Superpower}|{ExamScore}|{Rank}|{ThreatLevel}";
    }

}
