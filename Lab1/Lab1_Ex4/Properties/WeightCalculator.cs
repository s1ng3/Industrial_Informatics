using System;
using System.Management.Instrumentation;
using System.Runtime.CompilerServices;

namespace Lab1_Ex4.Properties
{
    public class WeightCalculator
    {
        public static void MenIdealWeight(float height, int years, char sex)
        {
            float IdealWeight;
            IdealWeight = (float)(height - 100 - ((height - 150) / 4)) + (years - 20) / 4;
            Console.WriteLine("The ideal weight for this criteria is: " + IdealWeight);
        }
        
        public static void WomenIdealWeight(float height, int years, char sex)
        {
            float IdealWeight;
            IdealWeight = (float)(height - 100 - ((height - 150) / 2.5)) + (years - 20) / 6;
            Console.WriteLine("The ideal weight for this criteria is: " + IdealWeight);
        }
    }
}