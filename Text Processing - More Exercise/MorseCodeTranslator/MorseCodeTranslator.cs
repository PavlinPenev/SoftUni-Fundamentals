using System;
using System.Text;

namespace MorseCodeTranslator
{
    class MorseCodeTranslator
    {
        static void Main(string[] args)
        {
            StringBuilder translated = new StringBuilder();
            string[] code = Console.ReadLine().Split(" | ");

            foreach (var word in code)
            {
                foreach (var w in word.Split())
                {
                    switch (w)
                    {
                        case ".-":
                            translated.Append("A");
                            break;
                        case "-...":
                            translated.Append("B");
                            break;
                        case "-.-.":
                            translated.Append("C");
                            break;
                        case "-..":
                            translated.Append("D");
                            break;
                        case ".":
                            translated.Append("E");
                            break;
                        case "..-.":
                            translated.Append("F");
                            break;
                        case "--.":
                            translated.Append("G");
                            break;
                        case "....":
                            translated.Append("H");
                            break;
                        case "..":
                            translated.Append("I");
                            break;
                        case ".---":
                            translated.Append("J");
                            break;
                        case "-.-":
                            translated.Append("K");
                            break;
                        case ".-..":
                            translated.Append("L");
                            break;
                        case "--":
                            translated.Append("M");
                            break;
                        case "-.":
                            translated.Append("N");
                            break;
                        case "---":
                            translated.Append("O");
                            break;
                        case ".--.":
                            translated.Append("P");
                            break;
                        case "--.-":
                            translated.Append("Q");
                            break;
                        case ".-.":
                            translated.Append("R");
                            break;
                        case "...":
                            translated.Append("S");
                            break;
                        case "-":
                            translated.Append("T");
                            break;
                        case "..-":
                            translated.Append("U");
                            break;
                        case "...-":
                            translated.Append("V");
                            break;
                        case ".--":
                            translated.Append("W");
                            break;
                        case "-..-":
                            translated.Append("X");
                            break;
                        case "-.--":
                            translated.Append("Y");
                            break;
                        case "--..":
                            translated.Append("Z");
                            break;
                    }
                }
                translated.Append(' ');
            }

            Console.WriteLine(translated);
        }
    }
}
