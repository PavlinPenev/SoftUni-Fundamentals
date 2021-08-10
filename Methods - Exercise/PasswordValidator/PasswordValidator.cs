using System;

namespace PasswordValidator
{
    class PasswordValidator
    {
        static void Main()
        {
            string password = Console.ReadLine().ToLower();

            if (!hasCharacters(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (!hasLettersDigitsOnly(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (!hasTwoDigits(password))
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (hasCharacters(password) && hasLettersDigitsOnly(password) && hasTwoDigits(password))
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool hasCharacters(string text)
        {
            if (text.Length >= 6 && text.Length <= 10)
            {
                return true;
            }
            return false;
        }

        static bool hasLettersDigitsOnly(string text)
        {
            bool isTrue = true;
            foreach (var symbol in text)
            {
                if (symbol >= 'a' && symbol <= 'z' || symbol >= '0' && symbol <= '9')
                {
                    isTrue = true;
                }
                else
                {
                    isTrue = false;
                    break;
                }
            }

            return isTrue;
        }

        static bool hasTwoDigits(string text)
        {
            int count = 0;
            foreach (var symbol in text)
            {
                if (symbol >= '0' && symbol <= '9')
                {
                    count++;
                }
            }

            if (count >= 2)
            {
                return true;
            } 
            return false;
            
        }
    }
}
