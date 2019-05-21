using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Campers2
{
    class Users
    {
        private List<string[]> users = new List<string[]>();

        public Users()
        {
            this.LoadUsers();
        }

        private void LoadUsers()
        {
            string[] user = new string[3];

            try
            {
                using(StreamReader sr = new StreamReader("Users.txt"))
                    while(sr.Peek() >= 0)
                    {
                        user = sr.ReadLine().Split('\t');
                        users.Add(user);
                    }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public bool ContainsUsername(string iUser)
        {
            // search first column of each list
            if (users.FirstOrDefault(array => array[0] == iUser) != null)
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

            if (users[index][2].Equals("true"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string[] ReturnAllUsers()
        {
            string[] oUsers = new string[users.Count()];

            for(int i =0; i< users.Count(); i++)
            {
                oUsers[i] = users[i][0];
            }

            return oUsers;
        }
    }
}
