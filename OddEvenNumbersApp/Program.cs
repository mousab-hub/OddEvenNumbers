using System;
using System.Collections.Generic;
using System.Linq;

namespace OddEvenNumbersApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            PrintNumbers("Numbers : ", numbers);
            PrintNumbers("Even Numbers ", numbers.Where(n => IsEven(n)));
            PrintNumbers("Odd Numbers ", numbers.Where(n => IsOdd(n)));


            Console.ReadLine();
        }

        static void PrintNumbers(string title,IEnumerable<int> numbers)
        {
            Console.WriteLine();
            Console.Write($"{title}: [");
            foreach (int n in numbers)
            {
                Console.Write($" {n}");
            }

            Console.Write(" ]");
            Console.WriteLine();
        }

        static bool IsEven(int number) => number % 2 == 0;


        static bool IsOdd(int number) => !IsEven(number);
       
    }
}
