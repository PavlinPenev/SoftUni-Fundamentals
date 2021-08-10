using System;
using System.Collections.Generic;
using System.Linq;

namespace StoreBoxes
{
    class StoreBoxes
    {
        static void Main(string[] args)
        {
            bool end = false;
            List<Box> boxes = new List<Box>();
            AddBoxes(end, boxes);
            boxes = boxes.OrderByDescending(b => b.BoxPrice).ToList();
            foreach (var box in boxes)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.BoxPrice:f2}");
            }
        }

        private static void AddBoxes(bool end, List<Box> boxes)
        {
            while (!end)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    end = true;
                    continue;
                }

                string[] data = input.Split();
                Item item = new Item();
                Box box = new Box();

                box.SerialNumber = data[0];
                item.Name = data[1];
                box.ItemQuantity = int.Parse(data[2]);
                item.Price = double.Parse(data[3]);
                box.BoxPrice = box.ItemQuantity * item.Price;
                box.Item = item;
                boxes.Add(box);
            }
        }
    }

    class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }

    class Box
    {
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public double BoxPrice { get; set; }
    }
}
