using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsAssignmentApp
{

    public class Computer
    {
        public string Brand { get; set; }
        public string Processor { get; set; }

        public Computer(string brand, string processor)
        {
            Brand = brand;
            Processor = processor;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Processor: {Processor}");
        }
    }

    public class Laptop : Computer
    {
        public bool IsTouchscreen { get; set; }

        public Laptop(string brand, string processor, bool isTouchscreen) : base(brand, processor)
        {
            IsTouchscreen = isTouchscreen;
        }

        public void ShowLaptopDetails()
        {
            ShowDetails();
            Console.WriteLine($"Touchscreen: {IsTouchscreen}");
        }
    }


    class SingleInheritance
    {
        public static void Print(int index) { 
            
            Console.WriteLine($"Example {index} : Single Inheritance using (Computer and Laptop):");
            Laptop myLaptop = new Laptop("Dell", "Intel i7", true);
            myLaptop.ShowLaptopDetails();
            //Console.WriteLine("");
        }
    }
}
