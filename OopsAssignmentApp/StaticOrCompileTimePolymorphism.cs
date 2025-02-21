using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsAssignmentApp
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

    class StaticOrCompileTimePolymorphism
    {

        public static void Print(int index)
        {

            Console.WriteLine($"Example {index} : Static Or CompileTime Polymorphism using method Overloading:");
            Calculator calc = new Calculator();

            int sum1 = calc.Add(5, 9);
            int sum2 = calc.Add(5, 9, 7);
            double sum3 = calc.Add(5.3, 9.2);

            Console.WriteLine("sum1 : " + sum1);
            Console.WriteLine("sum2 : " + sum2);
            Console.WriteLine("sum3 : " + sum3);

            //Console.ReadLine();
        }

    }
}
