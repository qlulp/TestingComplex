using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingComplex.Classes.Entities
{
    public class Question
    {
        public int ID { get; set; }
        public int BlockID { get; set; }
        public string QuestionStr { get; set; }
        public string WrongAnswer1 { get; set; }
        public string WrongAnswer2 { get; set; }
        public string WrongAnswer3 { get; set; }
        public string CorrectAnswer { get; set; }
    }
}
