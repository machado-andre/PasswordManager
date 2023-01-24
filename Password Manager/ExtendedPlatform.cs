using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Manager
{
    public partial class Platform
    {
        ProgramModelContainer Program;
        public Platform(string programName, string password, int User_id)
        {
            this.programName = programName;
            this.password = password;
            this.User_id = User_id;
        }

        public Platform() { }

        public override string ToString() {
            return programName.ToString();
        }
    }
}
