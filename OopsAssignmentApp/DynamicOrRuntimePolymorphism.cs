using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsAssignmentApp
{

    class ElectronicDevice
    {
        public virtual void DisplayShow()
        {
            Console.WriteLine("This is electronic device");
        }
    }
    //Using Method Overriding
    class MobilePhone : ElectronicDevice
    {
        public override void DisplayShow()
        {
            Console.WriteLine("This is mobile phone");
        }

    }

    class SmartPhone : ElectronicDevice
    {
        public override void DisplayShow()
        {
            Console.WriteLine("This is smart phone");
        }

    }


    class DynamicOrRuntimePolymorphism
    {
        public static void Print(int index)
        {
            Console.WriteLine($"Example {index} : Dynamic Or Runtime Polymorphism using method Overriding:");
            ElectronicDevice myDevice;// Base class reference

            myDevice = new MobilePhone(); // Reference to MobilePhone object
            myDevice.DisplayShow();


            myDevice = new SmartPhone(); // Reference to SmartPhone object
            myDevice.DisplayShow();


            //Console.ReadLine();
        }

    }
}
