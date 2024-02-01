using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicle_rental
{
    /// <summary>
    /// Class parent to create two derived classes Car & Truck
    /// </summary>
    internal abstract class Vehicle
    {
        //Properties required for the class Vehicle 
        public int VehicleId { get; set; }
        public string Make {  get; set; }
        public string Model { get; set; }
        public int Year {  get; set; }
        public double RentalRate { get; set; }

        //Parametarized Constructor 
        internal Vehicle(int vehicleId, string make, string model, int year, double rentalRate) 
        {
            VehicleId = vehicleId;
            Make = make;
            Model = model;
            Year = year;
            RentalRate = rentalRate;
        }

        //Abstract method 
        public virtual string DisplayInfo()
        {
            return $"Vehicle Id {VehicleId}, make {Make}, model {Model}, year {Year}, rental rate ${RentalRate}";
        }
    }
}
