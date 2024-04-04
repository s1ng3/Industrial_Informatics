using System;

namespace Lab1_Ex3.Properties
{
    public class TemperatureConverter
    {
        public static void C2F(float temperature)
        {
            float F;
            F = temperature * 9 / 5 + 32;
            Console.WriteLine(temperature + " Celsius grades are: " + F + " Fahrenheit grades.");
        }

        public static void F2C(float temperature)
        {
            float C;

            C = (temperature - 32) * 5 / 9;
            Console.WriteLine(temperature + " Fahrenheit grades are: " + C + " Celsius grades.");
        }
    }
}