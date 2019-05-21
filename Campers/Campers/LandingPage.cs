using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Campers
{
    public partial class LandingPage : Form
    {
        Users logInUsers = new Users();
        public static string user = string.Empty;
        public static bool isAdmin = false;

        public LandingPage()
        {
            InitializeComponent();            
        }

        private void button1_Click(object sender, EventArgs e)
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
                        // launch admin page
                        MainPage campers = new MainPage();
                        isAdmin = true;
                        campers.Show();
                          
                    }
                    else
                    {
                        // lanch user page
                        MainPage campers = new MainPage();
                        isAdmin = false;
                        campers.Show();
                    }

                }
                else
                {
                    MessageBox.Show("Incorrect password!");
                }
            }
            else
            {
                MessageBox.Show("Username not recognised!");
            }
        }

        private void LandingPage_Load(object sender, EventArgs e)
        {

        }
    }
}
