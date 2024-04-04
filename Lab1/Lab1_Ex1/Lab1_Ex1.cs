using System;

namespace Lab1_Ex1
{
    public class Lab1_Ex1
    {
        public static void Fn(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", FiboRecursiv(i));
            }
        }

        public static int FiboRecursiv(int n)
        {
            if (n <= 1)
                return n;
            else
                return FiboRecursiv(n - 1) + FiboRecursiv(n - 2);
        }

        static void Main(string[] args)
        {
            Console.Write("Enter n: "); 
            int n = Convert.ToInt32(Console.ReadLine()); //PRINTING VALUES

            Console.Write("First {0} terms of the Fibonacci sequence: ", n); //EXERCISE 1
            Fn(n);
        }
    }
}