using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class User
    {
        private string _password;

        public string Password
        {
            get { return _password; }
            set
            {
                if (value.Length < 6)
                {
                    Console.WriteLine("Password too short!");
                }
                else
                {
                    _password = value;
                }
            }
        }
    }
}
