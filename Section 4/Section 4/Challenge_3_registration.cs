using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisteringAndLogginIn
{
    class RegisteringAndLoggin
    {

        static string username;
        static string password;

        static void main(string[] args)
        {
            Register();
            Login();
            Console.Read();
        }

        public static void Register()
        {
            Console.WriteLine("Enter your username");
            username = Console.ReadLine();
            Console.WriteLine("Enter your password");
            password = Console.ReadLine();
            Console.WriteLine("Registration completed");
        }

        public static void Login()
        {
            Console.WriteLine("Enter your username");
            string userNameLogin = Console.ReadLine();
            if (username == userNameLogin)
            {
                Console.WriteLine("Enter your password");
                string passwordLogin = Console.ReadLine();
                if (password == passwordLogin)
                {
                    Console.WriteLine("Login successful");
                }
                else
                {
                    Console.WriteLine("Login failed, wrong password.");
                }
            }
            else
            {
                Console.WriteLine("Login failed, wrong username.");
            }
        }

    }
}
