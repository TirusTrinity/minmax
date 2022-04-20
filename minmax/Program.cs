using System;
using System.Collections.Generic;

namespace minmax
{
    class Program
    {
        public static string userInput;
        public static string[] split;
        public static List<Int32> ints = new();

        static void Main(string[] args)
        {
            Console.WriteLine("Skriv komma seperede tal værdier");
            userInput = Console.ReadLine();
            split = userInput.Split(',');
            for (int i = 0; i < split.Length; i++)
            {
                ints.Add(Int32.Parse(split[i]));
            }

            ints.Sort();
            Console.WriteLine(ints[ints.Count-1] );
            Console.ReadKey();
        }
    }
}
