using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicle_rental
{
    /// <summary>
    /// Child class extended from the Parent Class Vehicle 
    /// </summary>
    internal class Truck : Vehicle
    {
        //Properties required for the class Truck
        public float CargoCapacity { get; set; }

        //Parametarized Constructor 
        public Truck(int vehicleId, string make, string model, int year, double rentalRate, float cargoCapacity) :
            base(vehicleId, make, model, year, rentalRate)
        {
            CargoCapacity = cargoCapacity;
        }

        //Implement a specialized method DisplayInfo for Truck object 
        public override string DisplayInfo()
        {
            return $"Vehicle Id {this.VehicleId}, make {this.Make}, {this.Model}, year {this.Year} and cargo capacity {this.CargoCapacity}";
        }
    }
}
