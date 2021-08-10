using System;
using System.Collections.Generic;
using System.Linq;

namespace Snowwhite
{
    class Snowwhite
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, uint>> dwarfData = new Dictionary<string, Dictionary<string, uint>>();

            string[] inputData = Console.ReadLine().Split(" <:> ");
            while (inputData[0] != "Once upon a time")
            {
                string name = inputData[0];
                string hat = inputData[1];
                uint physic = uint.Parse(inputData[2]);
                if (!dwarfData.ContainsKey(hat))
                {
                    dwarfData.Add(hat, new Dictionary<string, uint>());
                    dwarfData[hat].Add(name, physic);
                }
                else
                {
                    if (!dwarfData[hat].ContainsKey(name))
                    {
                        dwarfData[hat].Add(name, physic);
                    }
                    else
                    {
                        if (dwarfData[hat][name] < physic)
                        {
                            dwarfData[hat][name] = physic;
                        }
                    }
                }
                inputData = Console.ReadLine().Split(" <:> ");
            }

            Dictionary<string, uint> dwData = new Dictionary<string, uint>();
            foreach (var dwarf in dwarfData.OrderByDescending(d => d.Value.Count))
            {
                foreach (var data in dwarf.Value)
                {
                    dwData.Add($"({dwarf.Key}) {data.Key} <-> ", data.Value);
                }
            }
            foreach (var dwarf in dwData.OrderByDescending(d => d.Value))
            {
                Console.WriteLine($"{dwarf.Key}{dwarf.Value}");
            }
        }
    }
}
