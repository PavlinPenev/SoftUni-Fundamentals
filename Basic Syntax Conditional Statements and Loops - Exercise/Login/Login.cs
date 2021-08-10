using System;
using System.Linq;

namespace Login
{
    class Login
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = string.Join("",username.Reverse());
            
            bool isPassword = false;
            bool isBlocked = false;
            int counterIncorrect = 0;
            while (isPassword == false)
            {
                string input = Console.ReadLine();

                if (counterIncorrect == 3 && input != password)
                {
                    isBlocked = true;
                    Console.WriteLine($"User {username} blocked!");
                }
                if (input != password && counterIncorrect < 3)
                {
                    counterIncorrect++;
                    Console.WriteLine("Incorrect password. Try again.");
                }
                else
                {
                    isPassword = true;
                }
            }
            if (isPassword && isBlocked != true)
            {
                Console.WriteLine($"User {username} logged in.");
            }
        }
    }
}
