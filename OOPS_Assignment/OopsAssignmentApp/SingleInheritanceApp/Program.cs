using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleInheritanceApp
{
    class Animal
    {
        public string Name { get; set; }

        public void Eat()
        {
            Console.WriteLine($"{Name} is eating");
        }

    }

    class Dog : Animal
    {

        public void Bark()
        {
            Console.WriteLine($"{Name} is barking");
        }

   
    }

   
    class Program
    {
        static void Main(string[] args)
        {

            Dog d = new Dog();
            d.Name = "Simba";
            d.Eat();
            d.Bark();

        }
    }
}
