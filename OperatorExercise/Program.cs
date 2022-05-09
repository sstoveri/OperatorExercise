using System;

namespace OperatorExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-----------------------------------------------Exercise 1------------------------------------------------
            double a = 17;
            double b = 4;
            double quotient = a / b;
            double remainder = a % b;

            Console.WriteLine($"{a} added to {b} equals to {a + b}");
            Console.WriteLine($"{a} subtracted by {b} equals to {a - b}");
            Console.WriteLine($"{a} muliplied by {b} equals to {a * b}");
            Console.WriteLine($"{a} divided by {b} equals to {a / b}");

            double answer = Add(a, b);
            Console.WriteLine(answer);
            double answer1 = Subtract(a, b);
            Console.WriteLine(answer1);
            double answer2 = Multiply(a, b);
            Console.WriteLine(answer2);
            double answer3 = Divide(a, b);
            Console.WriteLine(answer3);


            if (a == 17 && b == 4)
            {
                Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");
            }

            //-----------------------------------------------Exercise 2------------------------------------------------





        }
        public static double Add( double a, double b)
        {
            return a + b;
        }
        public static double Subtract(double a, double b)
        {
            return a - b;
        }
        public static double Multiply(double a, double b)
        {
            return a * b;
        }
        public static double Divide(double a, double b)
        {
            return a / b;
        }

        public static double AreaofCicle(double r)
        {
            return Math.PI * Math.Max(r, 2);
        }
    }
}
