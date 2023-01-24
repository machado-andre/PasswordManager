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
    public partial class newUserForm : Form
    {
        string key = "b14ca5898a4e4133bbce2ea2315a1916";
        public ProgramModelContainer Program;
        public newUserForm()
        {
            InitializeComponent();

            CenterToScreen();
            Program = new ProgramModelContainer();

            (from users in Program.Users
             select users).Load();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == null || textBoxPassword.Text == null)
                return;

            foreach(User user in Program.Users)
            {
                if(textBoxUsername.Text == user.name)
                {
                    MessageBox.Show("A user with this name already exists!");
                    return;
                }
            }

            User newUser = new User(textBoxUsername.Text, PasswordCypher.EncryptString(key, textBoxPassword.Text));
            try
            {
                Program.Users.Add(newUser);
                Program.SaveChanges();

                textBoxUsername.Text = "";
                textBoxPassword.Text = "";
                MessageBox.Show("User created successfully");
            }
            catch (Exception)
            {
                MessageBox.Show("Couldn't Save Changes");
            }
        }
    }
}
