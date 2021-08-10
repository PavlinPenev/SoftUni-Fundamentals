using System;
using System.Collections.Generic;

namespace ShoppingSpree
{
    class ShoppingSpree
    {
        static void Main()
        {
            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();
            string[] peopleData = Console.ReadLine().Split(';');
            foreach (var person in peopleData)
            {
                string[] data = person.Split('=');
                Person currentPerson = new Person(data[0], double.Parse(data[1]));
                people.Add(currentPerson);
            }

            string[] productData = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
            foreach (var product in productData)
            {
                string[] data = product.Split('=');
                Product currentProduct = new Product(data[0], double.Parse(data[1]));
                products.Add(currentProduct);
            }

            string buy = Console.ReadLine();
            while (buy != "END")
            {
                string[] action = buy.Split();
                int personIndex = people.FindIndex(p => p.Name == action[0]);
                int productIndex = products.FindIndex(pr => pr.Name == action[1]);
                if (people[personIndex].Money >= products[productIndex].Cost)
                {
                    people[personIndex].Money -= products[productIndex].Cost;
                    people[personIndex].ProductsBag.Add(products[productIndex]);
                    Console.WriteLine($"{people[personIndex].Name} bought {products[productIndex].Name}");
                }
                else
                {
                    Console.WriteLine($"{people[personIndex].Name} can't afford {products[productIndex].Name}");
                }
                buy = Console.ReadLine();
            }

            foreach (var person in people)
            {
                Console.WriteLine(person);
            }
        }
    }

    class Person
    {
        public Person(string name, double money)
        {
            Name = name;
            Money = money;
            ProductsBag = new List<Product>();
        }
        public string Name { get; set; }
        public double Money { get; set; }
        public List<Product> ProductsBag { get; set; }
        public override string ToString()
        {
            if (ProductsBag.Count == 0)
            {
                return $"{Name} - Nothing bought";
            }
            return $"{Name} - " + string.Join(", ", ProductsBag);
        }
    }

    class Product
    {
        public Product(string name, double cost)
        {
            Name = name;
            Cost = cost;
        }
        public string Name { get; set; }
        public double Cost { get; set; }
        public override string ToString()
        => Name;
    }
}
