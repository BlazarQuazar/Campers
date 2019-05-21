using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Campers2
{
    public partial class LogIn : Form
    {
        Users logInUsers = new Users();
        public static string user = string.Empty;
        public static bool isAdmin = false;

        public LogIn()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string iUsername = txtBoxUsername.Text;
            string iPassword = txtBoxPassword.Text;

            if (logInUsers.ContainsUsername(iUsername))
            {
                if (logInUsers.PasswordMatch(iUsername, iPassword))
                {
                    user = iUsername;

                    if (logInUsers.IsUserAdmin(iUsername))
                    {
                        isAdmin = true;
                    }
                    else
                    {
                        isAdmin = false;
                    }

                    txtBoxUsername.Text = string.Empty;
                    txtBoxPassword.Text = string.Empty;
                    MainPage mainPage = new MainPage();
                    mainPage.Show();

                }
                else
                {
                    MessageBox.Show("Incorrect password");
                }
            }
            else
            {
                MessageBox.Show("Username not recognised");
            }
        }
    }
}
