using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Manager
{
    public partial class User
    {
        ProgramModelContainer Program;

        public User(string name, string password)
        {
            this.name = name;
            this.password = password;
        }
    }
}
