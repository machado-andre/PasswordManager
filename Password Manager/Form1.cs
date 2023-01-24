using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Manager
{
    public partial class Form1 : Form
    {
        string key = "b14ca5898a4e4133bbce2ea2315a1916";
        public ProgramModelContainer Program;
        public User foundUser;
        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
            this.

            Program = new ProgramModelContainer();

            (from users in Program.Users
             select users).Load();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "" || textBoxUsername.Text == "")
            {
                return;
            }
            foreach(User user in Program.Users)
            {
                if(textBoxUsername.Text == user.name)
                {
                    foundUser = user;

                    if (PasswordCypher.DecryptString(key, foundUser.password) == textBoxPassword.Text)
                    {
                        hideWelcomePage();
                        showUserPage();
                        labelUsername.Text = "Hello " +foundUser.name+ "!";
                    }else{
                        MessageBox.Show("Wrong password.");
                    }
                    break;
                }
            }
            if (foundUser == null)
                MessageBox.Show("No User found with that name");
        }

        private void hideWelcomePage()
        {
            textBoxPassword.Visible = false;
            textBoxUsername.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            buttonLogin.Visible = false;
            btnCreateUser.Visible = false;
        }
        private void showUserPage()
        {
            btnAddProgram.Visible = true;
            btnCheckProgPass.Visible = true;
            labelUsername.Visible = true;
        }

        private void btnAddProgram_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm(foundUser);
            //this.Dispose();
            userForm.ShowDialog();
        }

        private void btnCheckProgPass_Click(object sender, EventArgs e)
        {
            UserProgramList userProgramList = new UserProgramList(foundUser);
            //this.Dispose();
            userProgramList.ShowDialog();
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            newUserForm newUser = new newUserForm();
            newUser.ShowDialog();
        }
    }
}
