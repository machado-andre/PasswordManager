using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Manager
{
    public partial class UserProgramList : Form
    {
        public ProgramModelContainer Program;
        User currentUser;
        string key = "b14ca5898a4e4133bbce2ea2315a1916";
        public UserProgramList(User user)
        {
            InitializeComponent();

            CenterToScreen();
            currentUser = user;
            Program = new ProgramModelContainer();

            (from platform in Program.Platforms
             select platform).Load();

            platformBindingSource.DataSource = Program.Platforms.Local.ToBindingList();
        }

        private void UserProgramList_Load(object sender, EventArgs e)
        {
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (listBoxUserPlatforms.SelectedIndex == -1)
                return;

            labelPassword.Visible = !labelPassword.Visible;

            Platform platformSelected = (Platform)listBoxUserPlatforms.SelectedItem;
            labelPassword.Text = PasswordCypher.DecryptString(key, platformSelected.password);

        }

        private void listBoxUserPlatforms_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelPassword.Visible = false;
        }
    }
}
