using System;

namespace EnglishNameOfTheLastDigit
{
    class EnglishNameOfTheLastDigit
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string tempString = string.Empty;
            switch (input[input.Length - 1])
            {
                case '0':
                    tempString = "zero";
                    break;
                case '1':
                    tempString = "one";
                    break;
                case '2':
                    tempString = "two";
                    break;
                case '3':
                    tempString = "three";
                    break;
                case '4':
                    tempString = "four";
                    break;
                case '5':
                    tempString = "five";
                    break;
                case '6':
                    tempString = "six";
                    break;
                case '7':
                    tempString = "seven";
                    break;
                case '8':
                    tempString = "eight";
                    break;
                case '9':
                    tempString = "nine";
                    break;
            }
            Console.WriteLine(tempString);
        }
    }
}
