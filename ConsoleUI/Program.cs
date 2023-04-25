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
             * DONE- Create an abstract class called Vehicle
             * DONE- The vehicle class shall have three string properties Year, Make, and Model
             * DONE- Set the defaults to something generic in the Vehicle class
             * DONE- Vehicle shall have an abstract method called DriveAbstract with no implementation
             * DONE- Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * DONE- Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * DONE- Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * DONE- Provide the implementations for the abstract methods
             * DONE- Only in the Motorcycle class will you override the virtual drive method
            */

            // DONE- Create a list of Vehicle called vehicles
            var vehicle = new List<Vehicle>();
            /*
             * DONE- Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * DONE- Set the properties with object initializer syntax
             */
            Car eqs = new Car() { HasTrunk = true, Make = "Mercedes", Model = "EQS", Year = 2022};
            Motorcycle shaPha = new Motorcycle() { HasSideCart = false, Make = "Honda", Model = "Shadow Phantom", Year = 2022};

            Vehicle lambo = new Car() { HasTrunk = false, Make = "Lamborghini", Model = "Terzo Millennio", Year = 2095 };
            Vehicle fiat = new Car() { Make = "Fiat", Model = "Multipla", Year = 1998 };
            /*
             * DONE- Add the 4 vehicles to the list
             * DONE- Using a foreach loop iterate over each of the properties
             */
            vehicle.Add(eqs);
            vehicle.Add(lambo);
            vehicle.Add(fiat);
            vehicle.Add(shaPha);

            foreach(var veh in vehicle)
            {
                Console.WriteLine($"Make: {veh.Make} Model: {veh.Model} Year: {veh.Year}");
                veh.DriveVirtual();
                veh.DriveAbstract();
                Console.WriteLine("------------------------------------------------------");
            }
            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
