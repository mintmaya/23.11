using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите две фразы");
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            string s3 = string.Concat(s1, "  ", s2);
            Console.WriteLine($"Результат объединения:  {s3}");

            int result = string.Compare(s1, s2);
            if (result == 0)
            {
                Console.WriteLine("Результат Compare: Строки идентичны");
            }
            else
            {
                if (result > 0)
                {
                    Console.WriteLine("Результат Compare: Строка 1 стоит после строки 2");
                }
                else
                {
                    Console.WriteLine("Результат Compare: Строка 1 перед строкой 2");
                }
            }

            bool result2 = string.Equals(s1, s2);
            if (result2 == false)
            {
                Console.WriteLine($"Результат Equals: строки не совпадают");
            }
            else
            {
                Console.WriteLine($"Результат Equals: строки совпадают");
            }

            int s5 = string.CompareOrdinal(s1, s2);
            Console.WriteLine($"Результат CompareOrdinal: {s5}");
            bool s6 = s3.Contains("Hello");

            if (s6 == true)
            {
                Console.WriteLine($"Результат Contains:да, строка содержит слово Hello");
            }
            else
            {
                Console.WriteLine($"Результат Contains:нет, строка нессодержит слово Hello");
            }


            char ch = 'o';
            int indexOfChar = s1.IndexOf(ch);
            Console.WriteLine($"Результат IndexOf: {indexOfChar}");
        }
    }
}