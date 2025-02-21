using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsAssignmentApp
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

    class MotorCycle : Vehicle
    {
        public void Ride()
        {
            Console.WriteLine("Motorcycle is riding.");
        }
    }


    class HierarchicalInheritance
    {

        public static void Print(int index)
        {
            Console.WriteLine($"Example {index} : Hierarchical Inheritance using (Vehical, Car and MotorCycle):");
            Car c = new Car();
            c.StartEngine();
            c.Drive();

            MotorCycle m = new MotorCycle();
            m.StartEngine();
            m.Ride();

            //Console.ReadLine();
        }

    }
}
