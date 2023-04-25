using System;
using CalculationLib1;
namespace Calculator
{
    class Program
    {

        public static void Main(string[] args)
        {

            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            CalculationLib1.CalculationLib1.Plus(a,b);
            CalculationLib1.CalculationLib1.Multiply(a, b);
            CalculationLib1.CalculationLib1.Divide(a, b);
            CalculationLib1.CalculationLib1.Minus(a, b);

        }
    }


}
