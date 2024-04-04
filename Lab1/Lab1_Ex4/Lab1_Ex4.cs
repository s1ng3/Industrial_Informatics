using System;
using Lab1_Ex4.Properties;

namespace Lab1_Ex4
{
    internal class Lab1_Ex4
    {
        public static void Main(string[] args)
        {
            float height;
            int years;
            char sex;

            height = (float)Convert.ToDecimal(Console.ReadLine());
            years = Convert.ToInt32(Console.ReadLine());
            sex = Convert.ToChar(Console.Read());
            
            Console.Write("\n");

            if (sex == 'm')
            {
                WeightCalculator.MenIdealWeight(height, years, sex);
                Console.Write("\n");
            }
            else if (sex == 'w')
            {
                WeightCalculator.WomenIdealWeight(height, years, sex);
                Console.Write("\n");
            }
            else
            {
                Console.WriteLine("Invalid format.");
                Console.Write("\n");
            }
        }
    }
}