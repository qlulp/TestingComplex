using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingComplex.Classes.Entities
{
    public class TestResult
    {
        public string Login { get; set; }
        public int BlockID { get; set; }
        public int CountOfQuestions { get; set; }
        public int CountOfCorrectAnswers { get; set; }
        public DateTime Date { get; set; }
        public int SecondsElapsed { get; set; }
    }
}
