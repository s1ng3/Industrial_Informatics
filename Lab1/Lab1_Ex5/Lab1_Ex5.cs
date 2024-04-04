using System;

namespace Lab1_Ex5
{
    internal class Lab1_Ex5
    {
        public static void Main(string[] args)
        {
            Console.Write("Introduceti numerele separate prin spatiu: ");
            string input = Console.ReadLine();
        
            string[] numereString = input.Split(' ');
            int[] numere = new int[numereString.Length];

            for (int i = 0; i < numereString.Length; i++)
            {
                if (int.TryParse(numereString[i], out int numar))
                {
                    numere[i] = numar;
                }
                else
                {
                    Console.WriteLine($"'{numereString[i]}' nu este un numar intreg valid.");
                }
            }

            if (numere.Length > 0)
            {
                double mediaAritmetica = CalculMediaAritmetica(numere);
                double mediaGeometrica = CalculMediaGeometrica(numere);

                Console.WriteLine($"Media Aritmetica: {mediaAritmetica}");
                Console.WriteLine($"Media Geometrica: {mediaGeometrica}");
            }
            else
            {
                Console.WriteLine("Nu ati introdus niciun numar valid.");
            }
        }

        static double CalculMediaAritmetica(int[] numere)
        {
            int suma = 0;
            foreach (int numar in numere)
            {
                suma += numar;
            }
            return (double)suma / numere.Length;
        }

        static double CalculMediaGeometrica(int[] numere)
        {
            double produs = 1;
            foreach (int numar in numere)
            {
                produs *= numar;
            }
            return Math.Pow(produs, 1.0 / numere.Length);
        }
    }
}