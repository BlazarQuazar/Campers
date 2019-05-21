using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Campers
{

    
    // Look up static classes & if methods can be shared
    class Users
    {
        private List<string[]> users = new List<string[]>();


        public Users()
        {
            // load the users into local storage, rethink would be needed for large number of users
            string[] user = new string[3];
                    
            try
            {
                using (StreamReader sr = new StreamReader("Users.txt"))
                    while (sr.Peek() >= 0)
                    {
                        user = sr.ReadLine().Split('\t');
                        users.Add(user);
                    }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error");
                Console.WriteLine(e.Message);
            }
            // at this point users is full of lists that contain, user-password-admin(true/false)

        }

        public bool ContainsUsername(string iUser)
        {
            // search first column of each list
            if(users.FirstOrDefault(array => array[0] == iUser) != null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool PasswordMatch(string iUser, string iPassword)
        {
            int index = users.FindIndex(array => array[0] == iUser);
            Debug.Write(users[index][1]);

            if (users[index][1].Trim().Equals(iPassword))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsUserAdmin(string iUser)
        {
            int index = users.FindIndex(array => array[0] == iUser);

            if (users[index][2] == "true")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        
    }
}
