using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles

            var vehicles = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties with object initializer syntax
             */

            var ford = new Car()
            {
                HasTrunk = true,
                TrunkSpace = 20
            };
            var harley = new Motorcycle()
            {
                HasSideCar = true,
                model = "Harley",
                make = "Sportster",
                year = 2022
            };

            Vehicle v1 = new Car()
            {
                HasTrunk = false,
                TrunkSpace= 0
            };
            v1.model = "Corolla";
            v1.make = "Toyota";
            v1.year = 2003;
     
       
            Vehicle v2 = new Motorcycle();
            v2.model = "Ducati";
            v2.make = "DesertX";
            v2.year = 2023;

            vehicles.Add(v1);
            vehicles.Add(v2);
            vehicles.Add(ford);
            vehicles.Add(harley);


            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */
            foreach(var vehicle in vehicles)
            {
                Console.WriteLine($"This is a {vehicle.year} {vehicle.make} {vehicle.model}");
                vehicle.DriveVirtual();
                vehicle.DriveAbstract();
                
            }
            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
