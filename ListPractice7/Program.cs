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
            bool changes = false;
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
                        changes = true;
                        break;
                    case "Remove":
                        numbers.Remove(int.Parse(command.ElementAtOrDefault(1)));
                        changes = true;
                        break;
                    case "RemoveAt":
                        numbers.RemoveAt(int.Parse(command.ElementAtOrDefault(1)));
                        changes = true;
                        break;
                    case "Insert":
                        numbers.Insert(int.Parse(command.ElementAtOrDefault(2)), int.Parse(command.ElementAtOrDefault(1)));
                        changes = true;
                        break;
                    case "Contains":
                        Console.WriteLine(numbers.Contains(int.Parse(command.ElementAtOrDefault(1))) ? "Yes" : "No such number");
                        break;
                    case "PrintEven":
                        Console.WriteLine(string.Join(" ", numbers.Where(num => num % 2 == 0)));
                        break;
                    case "PrintOdd":
                        Console.WriteLine(string.Join(" ", numbers.Where(num => num % 2 != 0)));
                        break;
                    case "GetSum":
                        Console.WriteLine(numbers.Sum());
                        break;
                    case "Filter":
                        int number = int.Parse(command.ElementAtOrDefault(2));
                        if (command.ElementAtOrDefault(1) == "<")
                        {
                            Console.WriteLine(string.Join(" ", numbers.Where(x => x < int.Parse(command.ElementAtOrDefault(2))).ToArray()));
                        }
                        else if (command.ElementAtOrDefault(1) == ">")
                        {
                            Console.WriteLine(string.Join(" ", numbers.Where(x => x > number).ToArray()));
                        }
                        else if (command.ElementAtOrDefault(1) == ">=")
                        {
                            Console.WriteLine(string.Join(" ", numbers.Where(x => x >= int.Parse(command.ElementAtOrDefault(2))).ToArray()));
                        }
                        else
                        {
                            Console.WriteLine(string.Join(" ", numbers.Where(x => x <= int.Parse(command.ElementAtOrDefault(2))).ToArray()));
                        }
                        break;
                    default:
                        //add
                        numbers.Add(int.Parse(command.ElementAtOrDefault(1)));
                        changes = true;
                        break;
                }
            }

            if (changes == true)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}