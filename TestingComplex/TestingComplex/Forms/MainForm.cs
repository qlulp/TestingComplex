using System.Drawing;
using System.Windows.Forms;
using TestingComplex.Classes;
using TestingComplex.Classes.Entities;
using TestingComplex.Controls;

namespace TestingComplex
{
    public partial class MainForm : Form
    {
        public User CurrentUser { get; private set; }
        private readonly Point PageLocation = new Point(78, 84);

        public TestsPage TestsPage;

        public MainForm()
        {
            InitializeComponent();

            State.Form = this;
            TestsPage = new TestsPage();
            this.Controls.Add(TestsPage);
            TestsPage.Location = PageLocation;
        }
    }
}
