using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CalculationLib1
{
    static public class CalculationLib1
    {
        static public double Plus(double a, double b)
        {
            a = a + b;
            Console.WriteLine(a);
            return a;
        }
        static public double Minus(double a, double b)
        {
            a = a - b;
            Console.WriteLine(a);
            return a;
        }
        static public double Divide(double a, double b)
        {
            a = a / b;
            Console.WriteLine(a);
            return a;
        }
        static public double Multiply(double a, double b)
        {
            a = a * b;
            Console.WriteLine(a);
            return a;
        }
    }
}
