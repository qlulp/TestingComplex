using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingComplex.Classes.Entities
{
    public class User
    {
        public string Login { get; private set; }
        public string FullName { get; set; }
        public DateTime Registered { get; private set; }
        public bool IsAdmin { get; set; }

        public User(string login, string fullname, DateTime registered, bool isAdmin)
        {
            Login = login;
            FullName = fullname;
            Registered = registered;
            IsAdmin = isAdmin;
        }
    }
}
