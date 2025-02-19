using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HierarchicalInheritanceExpl
{

    class Vehicle
    {
        public void StartEngine()
        {
            Console.WriteLine("Engine Started");
        }
    }

    class Car : Vehicle
    {
        public void Drive()
        {
            Console.WriteLine("Car is driving");
        }
    }

    class Boat : Vehicle
    {
        public void Sail()
        {
            Console.WriteLine("Boat is sailing.");
        }
    }
        
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.StartEngine();
            c.Drive();

            Boat b = new Boat();
            b.StartEngine();
            b.Sail();

            Console.ReadLine();
        }
    }
}
