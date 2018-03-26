using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eric_10374246.DataAccess
{
    class LoginData
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public LoginData() { }

        //intialise  
        public LoginData(string user, string pass)
        {
            Username = user;
            Password = pass;
        }
        //validate username 
        private bool UsernameValidator(string input)
        {
            string pattern = "[^a-zA-Z]";
            if (Regex.IsMatch(input, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //validate password
        private bool PwdValidator(string input)
        {
            string pattern = "[^a-zA-Z0-9]";
            if (Regex.IsMatch(input, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
 
        //clear user inputs 
        private void ClearTexts(string user, string pass)
        {
            user = String.Empty;
            pass = String.Empty;
        }
        //method to check if eligible to be logged in 
        internal bool IsLoggedIn(string user, string pass)
        {
            //check user name empty 
            if (string.IsNullOrEmpty(user))
            {
                MessageBox.Show("Invalid username");
                return false;

            }
            //check user name is valid type 
            else if (UsernameValidator(user) == true)
            {
                MessageBox.Show("Enter a valid username");
                ClearTexts(user, pass);
                return false;
            }
            //check user name is correct 
            else
            {
                if (Username != user)
                {
                    MessageBox.Show("Invalid username");
                    ClearTexts(user, pass);
                    return false;
                }
                //check password is empty 
                else
                {
                    if (string.IsNullOrEmpty(pass))
                    {
                        MessageBox.Show("Invalid password entered");
                        return false;
                    }
                    //check password is valid 
                    else if (PwdValidator(pass) == true)
                    {
                        MessageBox.Show("Password can only consist of A-Z, 0-9 ");
                        return false;
                    }
                    //check password is correct 
                    else if (Password != pass)
                    {
                        MessageBox.Show("Invalid password entered");
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
        }
    }
}
