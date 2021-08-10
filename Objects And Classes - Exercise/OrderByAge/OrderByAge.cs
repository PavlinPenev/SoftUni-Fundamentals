using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderByAge
{
    class OrderByAge
    {
        static void Main()
        {
            List<Person> people = new List<Person>();

            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] data = input.Split();
                Person currentPerson = new Person(data[0], data[1], int.Parse(data[2]));
                people.Add(currentPerson);
                input = Console.ReadLine();
            }

            people = people.OrderBy(p => p.Age).ToList();
            foreach (var person in people)
            {
                Console.WriteLine(person);
            }
        }
    }

    class Person
    {
        public Person(string name, string id, int age)
        {
            Name = name;
            ID = id;
            Age = age;
        }
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
        public override string ToString()
            => $"{Name} with ID: {ID} is {Age} years old.";
    }
}
