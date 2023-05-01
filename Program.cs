using System.Collections.Generic;
using System.ComponentModel;
// Ronda Rutherford
// 4/20/2023
// Practice - Inheritance
namespace Practice_Inheritance
{
    internal class Program
    {
        //        Create a global List of Vehicle
        static List<Vehicle> vehicles = new List<Vehicle>();
        static void Main(string[] args)
        {
            // In main create an instance of each class
            Vehicle vehicle = new Vehicle("red");
            Land land = new Land("green", 4);
            Air air = new Air("blue");
            Sea sea = new Sea("yellow", (Sea.Type)1);
            Plane plane = new Plane("grey", 4);
            Helicopter helicopter = new Helicopter("pink", 2);

            //Add each object to the Vehicle list
            vehicles.Add(vehicle);
            vehicles.Add(land);
            vehicles.Add(air);
            vehicles.Add(sea);
            vehicles.Add(plane);
            vehicles.Add(helicopter);

            //Use a loop to display the ToString information for each vehicle.
            foreach (Vehicle v in vehicles)
            {
                Console.WriteLine(v);
            }
        } // Main
    } // class
} // namespace