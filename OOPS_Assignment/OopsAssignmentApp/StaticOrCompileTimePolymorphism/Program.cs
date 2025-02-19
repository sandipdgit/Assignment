using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticOrCompileTimePolymorphism
{

    class Calculator
    {
        //Method Overloading
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        } 

        public double Add(double a, double b)
        {
            return a + b;
        }
    }

    class Program
    {
        static void Main()
        {
            Calculator calc = new Calculator();

            int sum1 = calc.Add(5,9);
            int sum2 = calc.Add(5, 9, 7);
            double sum3 = calc.Add(5.3, 9.2);

            Console.WriteLine("sum1 : " + sum1);
            Console.WriteLine("sum2 : " + sum2);
            Console.WriteLine("sum3 : " + sum3);

            Console.ReadLine();
        }
    }
}
