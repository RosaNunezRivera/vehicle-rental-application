using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicle_rental
{
    /// <summary>
    /// Static class to add vehicules, process rental transactions and print the Rental History 
    /// </summary>
    internal static class RentalAgency
    {
        private static List<Vehicle> vehiclesInventory = new List<Vehicle>();
        private static Dictionary<int, int> rentalsTransationsHistory = new Dictionary<int, int>();

        //Method to add vehicles to the inventory of rental car 
        public static void AddVehicleToInvetory(Vehicle vehicle) 
        {
            vehiclesInventory.Add(vehicle);
            Console.WriteLine($"The vehicle id {vehicle.VehicleId}, model {vehicle.Model} and {vehicle.Make} was added ");
            Console.WriteLine($"Now the vehicle's inventory is: {vehiclesInventory.Count}\n");
        }

        //Method to add vehicles to the inventory of rental car 
        public static void ProccessingRentals(Vehicle vehicle, AbstractRentalTransaction rentalTransaction) 
        {
            if (vehicle is Car || vehicle is Truck)
            {
                double rentalCost = rentalTransaction.CalculateRentalCost(vehicle);
                rentalsTransationsHistory.Add(rentalTransaction.TransactionId, vehicle.VehicleId);
                Console.WriteLine($"The rental transaction with id {rentalTransaction.TransactionId} had beeen processed");
            }
            else
            {
                Console.WriteLine($"Please add a vehicle or truck object");
            }

        }

        //Method to Display Rental History 
        public static void DisplayingRentalHistory() 
        {
            // Display information about each car rental
            Console.WriteLine("Rentals Transaction History:");
            foreach (var entry in rentalsTransationsHistory)
            {
                int transactionId = entry.Key;
                int vehicleId = entry.Value;

                Console.WriteLine($"Transaction ID: {transactionId} Vehicle id: {vehicleId}");
            }
        }
    }
}
