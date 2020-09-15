using System;
using System.Globalization;


namespace Calculator
{
    public class Calculator
    {
        public double add(double a, double b)
        {
            return a + b;
        }

        public double sub(double a, double b)
        {
            return a - b;
        }

        public double mul(double a, double b)
        {
            return a * b;
        }

        public double? div(double a, double b)
        {
            if (b < 1e-7)
            {
                Console.WriteLine("You can not divide by zero.");
                return null;
            }
            return a / b;
        }

        public int? rem(int a, int b)
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
    }  // class Calculator

    class ExecuteMain
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                Console.Write("\nEnter first operand: ");
                double a = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);

                Console.Write("Enter operator (+ - * / %): ");
                char o = Convert.ToChar(Console.ReadLine());

                Console.Write("Enter second operand: ");
                double b = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);


                Calculator calc = new Calculator();

                switch (o)
                {
                    case '+':
                        Console.WriteLine($"Result: {calc.add(a, b):f4}");
                        break;

                    case '-':
                        Console.WriteLine($"Result: {calc.sub(a, b):f4}");
                        break;

                    case '*':
                        Console.WriteLine($"Result: {calc.mul(a, b):f4}");
                        break;

                    case '/':
                        Console.WriteLine($"Result: {calc.div(a, b):f4}");
                        break;

                    case '%':
                        int ai = Convert.ToInt32(a);
                        int bi = Convert.ToInt32(b);
                        Console.WriteLine($"Result: {calc.rem(ai, bi)}");
                        break;
                }
            }  // for (;;)
        }
    }  // class ExecuteMain
}
