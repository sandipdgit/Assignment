using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilevelInheritanceExpl
{
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating..");
        }

    }

    class Mammal : Animal
    {

        public void Walk()
        {
            Console.WriteLine("Walking..");
        }


    }

    class Dog : Mammal
    {

        public void Bark()
        {
            Console.WriteLine("Barking..");
        }


    }


    class Program
    {
        static void Main(string[] args)
        {

            Dog d = new Dog();
           
            d.Eat();  // Inherited from Animal
            d.Walk(); // Inherited from Mammal
            d.Bark(); // Defined in Dog

            Console.ReadLine();

        }
    }
}
