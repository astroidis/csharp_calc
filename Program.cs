using System;
using System.Globalization;


namespace Calculator
{
    class Calculator
    {
        static double add(double a, double b)
        {
            return a + b;
        }

        static double sub(double a, double b)
        {
            return a - b;
        }

        static double mul(double a, double b)
        {
            return a * b;
        }

        static double? div(double a, double b)
        {
            if (b < 1e-7)
            {
                Console.WriteLine("You can not divide by zero.");
                return null;
            }
            return a / b;
        }

        static int? rem(int a, int b)
        {
            try
            {
                return a % b;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("You can not divide by zero.");
                return null;
            }
        }

        static void Main(string[] args)
        {
            for(; ; )
            {

                Console.Write("\nEnter first operand: ");
                double a = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);

                Console.Write("Enter operator (+ - * / %): ");
                char o = Convert.ToChar(Console.ReadLine());

                Console.Write("Enter second operand: ");
                double b = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);

                switch (o)
                {
                    case '+':
                        Console.WriteLine($"Result: {add(a, b):f4}");
                        break;

                    case '-':
                        Console.WriteLine($"Result: {sub(a, b):f4}");
                        break;

                    case '*':
                        Console.WriteLine($"Result: {mul(a, b):f4}");
                        break;

                    case '/':
                        Console.WriteLine($"Result: {div(a, b):f4}");
                        break; 
                    
                    case '%':
                        int ai = Convert.ToInt32(a);
                        int bi = Convert.ToInt32(b);
                        Console.WriteLine($"Result: {rem(ai, bi)}");
                        break;
                }
            }  // for (;;)
        }
    }
}
