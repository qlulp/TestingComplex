using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Timers;
using TestingComplex.Classes.Entities;

namespace TestingComplex.Classes
{
    class State
    {
        public static MainForm Form { get; set; }
        public static string Login { get; set; }

        public static int SelectedBlockID;
        public static int QuestionIndex = 0;
        public static Question[] Questions { get; set; }
        public static bool[] Results { get; set; }
        public static Stopwatch Watch = new Stopwatch();
    }
}
