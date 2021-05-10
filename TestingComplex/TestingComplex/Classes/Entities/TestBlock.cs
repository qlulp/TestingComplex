using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingComplex.Classes.Entities
{
    public class TestBlock
    {
        public int ID { get; private set; }
        public string Name { get; set; }
        public DateTime DateOfCreation { get; private set; }

        public TestBlock(int id, string name, DateTime dateOfCreation)
        {
            ID = id;
            Name = name;
            DateOfCreation = dateOfCreation;
        }
    }
}
