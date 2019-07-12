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
            List<double> numbersOne = Console.ReadLine().Split().Select(double.Parse).ToList();
            List<double> numbersTwo = Console.ReadLine().Split().Select(double.Parse).ToList();
            List<double> result = new List<double>();

            if (numbersOne.Count > numbersTwo.Count)
            {
                for (int i = 0; i < numbersTwo.Count; i++)
                {
                    result.Add(numbersOne.ElementAtOrDefault(0));
                    result.Add(numbersTwo.ElementAtOrDefault(i));
                    numbersOne.RemoveAt(0);
                }
                result.AddRange(numbersOne);
            }
            else
            {
                for (int i = 0; i < numbersOne.Count; i++)
                {
                    result.Add(numbersOne.ElementAtOrDefault(i));
                    result.Add(numbersTwo.ElementAtOrDefault(0));
                    numbersTwo.RemoveAt(0);
                }
                result.AddRange(numbersTwo);
            }

            for (int i = 0; i < result.Count; i++)
            {
                Console.Write(result.ElementAtOrDefault(i));
                if (i < result.Count - 1)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}