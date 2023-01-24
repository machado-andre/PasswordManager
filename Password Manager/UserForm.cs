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
    public partial class UserForm : Form
    {
        public ProgramModelContainer Program;
        Random rnd = new Random();
        User currentUser;
        string key = "b14ca5898a4e4133bbce2ea2315a1916";
        public UserForm(User user)
        {
            InitializeComponent();
            CenterToScreen();

            currentUser = user;
            Program = new ProgramModelContainer();

        }

        private void btnGeneratePass_Click(object sender, EventArgs e)
        {
            char lowerCaseLetter1 = (char)rnd.Next(97, 123);
            char upperCaseLetter1 = (char)rnd.Next(65, 91);
            char number1 = (char)rnd.Next(48, 58);
            char specialChar1 = (char)rnd.Next(33, 48);

            char lowerCaseLetter2 = (char)rnd.Next(97, 123);
            char upperCaseLetter2 = (char)rnd.Next(65, 91);
            char number2 = (char)rnd.Next(48, 58);
            char specialChar2 = (char)rnd.Next(33, 48);

            string password = lowerCaseLetter1.ToString()
                            + upperCaseLetter1.ToString()
                            + number1.ToString()
                            + specialChar1.ToString()
                            + lowerCaseLetter2.ToString()
                            + upperCaseLetter2.ToString()
                            + number2.ToString()
                            + specialChar2.ToString();
            password = shuffleString(password);
            textBoxPassword.Text = password;
            MessageBox.Show("Password Generated:\n"+password);
        }

        private string shuffleString(string str)
        {
            char[] array = str.ToCharArray();
            int n = array.Length;
            while (n > 1)
            {
                n--;
                int k = rnd.Next(n + 1);
                var value = array[k];
                array[k] = array[n];
                array[n] = value;
            }
            return new string(array);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(textBoxProgram.Text == null || textBoxPassword.Text == null)
                return;

            foreach (Platform platform in currentUser.Platforms)
            {
                if (textBoxProgram.Text == platform.programName)
                {
                    MessageBox.Show("You've already saved a password for this program!");
                    return;
                }
            }

            Platform newPlatform = new Platform(textBoxProgram.Text, PasswordCypher.EncryptString(key, textBoxPassword.Text),currentUser.id);

            try
            {
                Program.Platforms.Add(newPlatform);
                Program.SaveChanges();

                textBoxProgram.Text = "";
                textBoxPassword.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Couldn't Save Changes");
            }
            MessageBox.Show(PasswordCypher.DecryptString(key,newPlatform.password) + " - To check your password again please head to the Programs List! :)");
        }
    }
}
