using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicOrRuntimePolymorphism
{

    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal Speaks");
        }
    }
    //Using Method Overriding
    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Dog can barks");
        }

    }

    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Cat can meows");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal;// Base class reference

            myAnimal = new Dog(); // Reference to Dog object
            myAnimal.Speak();


            myAnimal = new Cat(); // Reference to Cat object
            myAnimal.Speak();


            Console.ReadLine();


        }
    }
}
