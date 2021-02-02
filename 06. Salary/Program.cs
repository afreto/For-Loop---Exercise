using System;
using System.ComponentModel.Design;
using System.Reflection.Metadata;

namespace _06._Salary
{
    class Program
    {
        static void Main(string[] args)
        { 
            const int facebook = 150;
            const int instagram = 100;
            const int reddit = 50;
            int n = int.Parse(Console.ReadLine());
            int sallary = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string site = Console.ReadLine();
                switch (site)
                {
                    case "Facebook":
                        sallary -= facebook;
                        break;
                    case "Instagram":
                        sallary -= instagram;
                        break;
                    case "Reddit":
                        sallary -= reddit;
                        break;
                }
                if (sallary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
            }
            if (sallary > 0)
            {
                Console.WriteLine(sallary);
            }
        }
    }
}
