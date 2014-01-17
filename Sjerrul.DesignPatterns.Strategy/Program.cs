using Sjerrul.DesignPatterns.Strategy.Business;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sjerrul.DesignPatterns.Strategy
{
    public class Program
    {
        private static int _numberOfItems = 10;
        private static int _maxValue = 100;

        static void Main(string[] args)
        {
            int[] integers = FillIntegerList();

            PrintCollection(integers);   

            Sorter sorter = new Sorter(new ShellSort());
            sorter.Sort(integers);

            PrintCollection(integers);
            Console.ReadLine();
        }

        private static void PrintCollection<T>(IEnumerable<T> collection)
        {
            StringBuilder stringBuilder = new StringBuilder();

            T firstItem = collection.First();
            stringBuilder.Append(firstItem);
            foreach (T item in collection.Skip(1))
            {
                stringBuilder.Append(String.Format(", {0}", item));
            }

            Console.WriteLine(stringBuilder.ToString());

        }

        private static int[] FillIntegerList()
        {
            int[] integers = new int[_numberOfItems];

            Random random = new Random();
            for (int i = 0; i < _numberOfItems; i++)
            {
                integers[i] = random.Next(_maxValue);
            }

            return integers;
        }
    }
}
