using System;

namespace _02._Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxVal = int.MinValue;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;
                if (num > maxVal)
                {
                    maxVal = num;
                }
            }
            int sumWithoutMax = sum - maxVal;
            if (sumWithoutMax == maxVal)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {maxVal}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(maxVal - sumWithoutMax)}");
            }
        }
    }
}
