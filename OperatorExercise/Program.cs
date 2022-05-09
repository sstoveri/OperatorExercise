using System;

namespace OperatorExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-----------------------------------------------Exercise 1------------------------------------------------



            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;


            if (a == 17 && b == 4)
            {
                Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");
            }

            //-----------------------------------------------Exercise 2------------------------------------------------





        }

        public static double AreaofCicle(double r)
        {
            return Math.PI * Math.Max(r, 2);
        }
    }
}
