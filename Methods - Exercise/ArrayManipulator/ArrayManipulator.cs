using System;
using System.Linq;

namespace ArrayManipulator
{
    class ArrayManipulator
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            bool end = false; //boolean to control the while loop
            string finalArray = string.Join(" ", input);  //used to store the final result in string(so I can manipulate easier in methods)
            int[] temp = finalArray.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();//used for in between methods operations and final print value 
            while (!end)
            {
                string command = Console.ReadLine();
                if (command == "end") //while loop break condition
                {
                    end = true;
                    continue;
                }

                string[] action = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                switch (action[0])
                {
                    case "exchange"://action[0] = "exchange", action[1] = value of how many indexes u should trim and swap places into the array(with a string value, thats why I'm parsing it in the "if" constructs)
                        if (int.Parse(action[1]) > input.Length - 1 || int.Parse(action[1]) < 0)
                        {
                            Console.WriteLine("Invalid index"); //if action[1] is out of the array bounds print Invalid index
                            break;
                        }
                        finalArray = Exchange(temp, int.Parse(action[1]));
                        temp = finalArray.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();//"after operation" values of the array in both types - string and int[]
                        break;
                    case "max":
                        if (Max(temp, action[1]) == int.MaxValue)//Max() method takes an int[] and string("odd" or "even") as arguments
                        {
                            Console.WriteLine("No matches"); //Have a variable in Max() which holds int.MaxValue, it holds the value of the index in the array with the chosen element, if it's not changed no match is found so - print "No matches"
                            break;
                        }

                        Console.WriteLine(Max(temp, action[1]));//prints the index of the match
                        break;
                    case "min":
                        if (Min(temp, action[1]) == int.MaxValue)
                        {
                            Console.WriteLine("No matches"); //analogical of the Max() method
                            break;
                        }

                        Console.WriteLine(Min(temp, action[1]));
                        break;
                    case "first": // First() takes three arguments - array, int(count of elements to return) and string(even or odd), returns the first {count} even/odd elements
                        if (int.Parse(action[1]) > temp.Length)
                        {
                            Console.WriteLine("Invalid count"); //if the count argument is bigger than the length of the array print Invalid count
                            break;
                        }

                        if (First(temp, int.Parse(action[1]), action[2]) == string.Empty)
                        {
                            Console.WriteLine("[]"); //if you don't find any matches print empty array
                            break;
                        }

                        string[] firstArray = First(temp, int.Parse(action[1]), action[2]).Split(" ", StringSplitOptions.RemoveEmptyEntries);
                        Console.WriteLine($"[{string.Join(", ", firstArray)}]"); //if you meet the conditions print result
                        break;
                    case "last":
                        if (int.Parse(action[1]) > temp.Length)   //analogically of First() method, this one returns the last {count} even/odd elements
                        {
                            Console.WriteLine("Invalid count");
                            break;
                        }

                        if (Last(temp, int.Parse(action[1]), action[2]) == string.Empty)
                        {
                            Console.WriteLine("[]");
                            break;
                        }

                        string[] lastArray = Last(temp, int.Parse(action[1]), action[2]).Split(" ", StringSplitOptions.RemoveEmptyEntries);
                        Console.WriteLine($"[{string.Join(", ", lastArray)}]");
                        break;
                }

            }

            Console.WriteLine($"[{string.Join(", ", temp)}]");
        }//Methods used are bellow

        static string Exchange(int[] x, int y)
        {
            int[] leftArray = new int[y + 1];
            int[] rightArray = new int[x.Length - y - 1];
            int[] newArray = new int[x.Length]; //left array to save the values on the left side of the separating index(int y) and right array - the values on the right side. newArray is the final result after the swap
            string array = string.Empty;

            for (int i = 0; i <= y; i++)
            {
                leftArray[i] = x[i];
            }


            int counter = 0;
            for (int i = y + 1; i < x.Length; i++)
            {
                rightArray[counter] = x[i];
                counter++;
            }

            array = string.Join(" ", rightArray);
            array += " " + string.Join(" ", leftArray);
            return array;
        }

        static int Max(int[] x, string evenOdd)
        {
            int index = int.MaxValue;
            int temp = int.MinValue;

            switch (evenOdd)
            {
                case "even":
                    for (int i = 0; i < x.Length; i++)
                    {
                        if (x[i] % 2 == 0 && x[i] >= temp)
                        {
                            index = i;
                            temp = x[i];
                        }
                    }
                    break;
                case "odd":
                    for (int i = 0; i < x.Length; i++)
                    {
                        if (x[i] % 2 != 0 && x[i] >= temp)
                        {
                            index = i;
                            temp = x[i];
                        }
                    }
                    break;
            }

            return index;
        }

        static int Min(int[] x, string evenOdd)
        {
            int index = int.MaxValue;
            int temp = int.MaxValue;

            switch (evenOdd)
            {
                case "even":
                    for (int i = 0; i < x.Length; i++)
                    {
                        if (x[i] % 2 == 0 && x[i] <= temp)
                        {
                            index = i;
                            temp = x[i];
                        }
                    }
                    break;
                case "odd":
                    for (int i = 0; i < x.Length; i++)
                    {
                        if (x[i] % 2 != 0 && x[i] <= temp)
                        {
                            index = i;
                            temp = x[i];
                        }
                    }
                    break;
            }

            return index;
        }

        static string First(int[] x, int y, string z)
        {
            int counter = 0;
            string newArray = string.Empty;
            switch (z)
            {
                case "even":
                    for (int i = 0; i < x.Length; i++)
                    {
                        if (counter >= y)
                        {
                            break;
                        }
                        if (x[i] % 2 == 0)
                        {
                            newArray += x[i] + " ";
                            counter++;
                        }
                    }

                    break;
                case "odd":
                    for (int i = 0; i < x.Length; i++)
                    {
                        if (counter >= y)
                        {
                            break;
                        }
                        if (x[i] % 2 != 0)
                        {
                            newArray += x[i] + " ";
                            counter++;
                        }
                    }

                    break;
            }

            return newArray;
        }

        static string Last(int[] x, int y, string z)
        {
            int counter = 0;
            string newArray = string.Empty;
            switch (z)
            {
                case "even":
                    for (int i = x.Length - 1; i >= 0; i--)
                    {
                        if (counter >= y)
                        {
                            break;
                        }
                        if (x[i] % 2 == 0)
                        {
                            newArray += x[i] + " ";
                            counter++;
                        }
                    }

                    break;
                case "odd":
                    for (int i = x.Length - 1; i >= 0; i--)
                    {
                        if (counter >= y)
                        {
                            break;
                        }
                        if (x[i] % 2 != 0)
                        {
                            newArray += x[i] + " ";
                            counter++;
                        }
                    }

                    break;
            }

            int[] newArrayInt = newArray.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            newArray = string.Join(" ", newArrayInt.Reverse());

            return newArray;
        }
    }
}
