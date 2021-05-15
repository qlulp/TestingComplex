using System.Drawing;
using System.Windows.Forms;
using TestingComplex.Classes;
using TestingComplex.Classes.Entities;
using TestingComplex.Controls;
using TestingComplex.Controls.Pages;

namespace TestingComplex
{
    public partial class MainForm : Form
    {
        public User CurrentUser { get; private set; }
        public SideMenuControl SideMenu { get; private set; }
        public HeaderControl Header { get; private set; }
        private readonly Point PageLocation = new Point(78, 84);

        private Control _CurrentPage;
        public Control CurrentPage
        {
            get => _CurrentPage;
            set
            {
                if (_CurrentPage != null)
                {
                    _CurrentPage.Dispose();
                }
                _CurrentPage = value;
                _CurrentPage.Location = PageLocation;
                this.Controls.Add(_CurrentPage);
                    
            }
        }

        public MainForm()
        {
            InitializeComponent();

            State.Form = this;
            CurrentPage = new TestsPage();
            SideMenu = new SideMenuControl();
            Header = new HeaderControl();
            this.Controls.Add(SideMenu);
            this.Controls.Add(Header);
            SideMenu.Location = new Point(0, 0);
            Header.Location = new Point(76, 20);
            dragHeader.TargetControl = Header;
        }

    }
}
