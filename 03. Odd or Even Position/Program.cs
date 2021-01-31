using System;

namespace _03._Odd_or_Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sumEven = 0;
            double minEven = double.MaxValue;
            double maxEven = double.MinValue;
            double sumOdd = 0;
            double minOdd = double.MaxValue;
            double maxOdd = double.MinValue;
            for (int i = 1; i <= n; i++)
            {
                double num = double.Parse(Console.ReadLine());
                //check is even or odd
                if (i % 2 == 0)
                {
                    //is even 
                    sumEven += num;
                    if (num < minEven)
                    {
                        minEven = num;
                    }
                    if (num > maxEven)
                    {
                        maxEven = num;
                    }
                }
                else
                {
                    //is odd
                    sumOdd += num;
                    if (num < minOdd)
                    {
                        minOdd = num;
                    }
                    if (num > maxOdd)
                    {
                        maxOdd = num;
                    }
                }
            }
            if (sumOdd != 0)
            {
                Console.WriteLine($"OddSum={sumOdd:f2},");
                Console.WriteLine($"OddMin={minOdd:f2},");
                Console.WriteLine($"OddMax={maxOdd:f2},");
            }
            else
            {
                Console.WriteLine($"OddSum={sumOdd:f2},");
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,");
            }
            if (sumEven != 0)
            {
                Console.WriteLine($"EvenSum={sumEven:f2},");
                Console.WriteLine($"EvenMin={minEven:f2},");
                Console.WriteLine($"EvenMax={maxEven:f2}");
            }
            else
            {
                Console.WriteLine($"EvenSum={sumEven:f2},");
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }
        }
    }
}
