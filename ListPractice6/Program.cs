using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end")
                {
                    break;
                }

                string[] command = line.Split();

                switch (command.FirstOrDefault())
                {
                    case "Add":
                        numbers.Add(int.Parse(command.ElementAtOrDefault(1)));
                        break;
                    case "Remove":
                        numbers.Remove(int.Parse(command.ElementAtOrDefault(1)));
                        break;
                    case "RemoveAt":
                        numbers.RemoveAt(int.Parse(command.ElementAtOrDefault(1)));
                        break;
                    case "Insert":
                        numbers.Insert(int.Parse(command.ElementAtOrDefault(2)), int.Parse(command.ElementAtOrDefault(1)));
                        break;
                    default:
                        numbers.Add(int.Parse(command.ElementAtOrDefault(1)));
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}