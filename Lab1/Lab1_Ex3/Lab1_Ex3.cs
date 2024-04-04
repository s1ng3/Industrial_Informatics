using System;
using Lab1_Ex3.Properties;

namespace Lab1_Ex3

{
    internal class Lab1_Ex3
    {
        public static void Main(string[] args)
        {

            float temperature;

            temperature = (float)Convert.ToDecimal(Console.ReadLine());
            Console.Write("\n");
            
            TemperatureConverter.C2F(temperature);
            Console.Write("\n");
            TemperatureConverter.F2C(temperature);
            Console.Write("\n");
        }
    }
}