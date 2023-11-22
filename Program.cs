using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create instances of Smartphone and Laptop classes
            SmartPhone smartphone = new SmartPhone("Apple", "iPhone 12");
            Laptop laptop = new Laptop("Dell", "XPS 13");

            // Set their properties
            smartphone.Brand = "Apple";
            smartphone.Model = "iPhone 12";
            laptop.Brand = "Dell";
            laptop.Model = "XPS 13";

            // Call the methods from each interface
            smartphone.Connect();
            smartphone.Recharge(60);
            laptop.Connect();
            laptop.Recharge(120);

            // Print the information for each device
            Console.WriteLine(smartphone.Display());
            Console.WriteLine(laptop.Display());
            Console.ReadKey();
        }
    }
}
