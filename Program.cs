using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace vehicle_rental
{
    internal class Program
    {
        /// <summary>
        /// Program to implement a Vehicle Rental using Polymorphism and Abstract Classes
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Vehicle Rental using Polymorphism and Abstract Classes");
            Console.WriteLine("Implementation\n");

            Console.WriteLine("1. Adding Vehicles to Inventory");
            Console.WriteLine("-------------------------------");

            //Creating new objects (instance) of the class Car
            Car car1 = new Car(100, "Kia", "Sedan", 2022, 50.0, 4, 2);
            Car car2 = new Car(101, "Ford", "Mustang", 2018, 85.0, 4, 4);

            //Creating new objects (instance) of the class Truck
            Truck truck1 = new Truck(103, "Ford", "F150", 2023, 100.0, 5_000);
            Truck truck2 = new Truck(104, "Chevrolet", "Silverado", 2024, 120.0, 6_000);

            //Adding vehicles to the inventory of the rental car
            RentalAgency.AddVehicleToInvetory(car1);
            RentalAgency.AddVehicleToInvetory(car2);
            RentalAgency.AddVehicleToInvetory(truck1);
            RentalAgency.AddVehicleToInvetory(truck2);

            //Declaring dates for 4 rent transactions  
            DateTime dateStart1 = new DateTime(2024, 1, 30);
            DateTime dateStart2 = new DateTime(2024, 1, 31);
            DateTime dateStart3 = new DateTime(2024, 2, 1);
            DateTime dateStart4 = new DateTime(2024, 2, 2);

            DateTime dateEnd1 = new DateTime(2024, 2, 2);
            DateTime dateEnd2 = new DateTime(2024, 2, 4);
            DateTime dateEnd3 = new DateTime(2024, 2, 5);
            DateTime dateEnd4 = new DateTime(2024, 2, 10);

            DateTime dateActualReturn1 = new DateTime(2024, 2, 3);  
            DateTime dateActualReturn2 = new DateTime(2024, 2, 7);  
            DateTime dateActualReturn3 = new DateTime(2024, 2, 6);  
            DateTime dateActualReturn4 = new DateTime(2024, 2, 15);  

            Console.WriteLine("\n2. Process Rentals");
            Console.WriteLine("-------------------");

            //Creating 4 rental transactions 
            CarRental carRental1 = new CarRental(1, dateStart1, dateEnd1, "Rosa Nunez", dateActualReturn1);
            CarRental carRental2 = new CarRental(2, dateStart2, dateEnd2, "E. J. Lopez", dateActualReturn2);
            CarRental carRental3 = new CarRental(3, dateStart3, dateEnd3, "Ivan Lopez", dateActualReturn3);
            CarRental carRental4 = new CarRental(4, dateStart4, dateEnd4, "Jafet Lopez", dateActualReturn4);

            //Processing rental transactions 
            RentalAgency.ProccessingRentals(car1, carRental1); //Rate 50.0
            RentalAgency.ProccessingRentals(car2, carRental2); //Rate 85.0
            RentalAgency.ProccessingRentals(truck1, carRental3); //Rate 100.0
            RentalAgency.ProccessingRentals(truck2, carRental4); //Rate 120.0

            //Displaying rental transactions 
            Console.WriteLine("\n3. Display Rental History");
            Console.WriteLine("----------------------------");

            RentalAgency.DisplayingRentalHistory();
            Console.ReadKey();
        }
    }
}
