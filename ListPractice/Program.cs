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
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers.ElementAtOrDefault(i) == numbers.ElementAtOrDefault(i + 1))
                {
                    numbers[i] += numbers.ElementAtOrDefault(i + 1);
                    numbers.RemoveAt(i + 1);
                    i = -1;
                }
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write(numbers.ElementAtOrDefault(i));
                if (i < numbers.Count - 1)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}
