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
    internal class Car : Vehicle
    {
        //Properties required for the class Car
        public int NumbersOfDoors {  get; set; }
        public int NumbersofCilinders { get; set; }

        //Parametarized Constructor 
        public Car(int vehicleId, string make, string model, int year, double rentalRate, int numbersOfDoors, int numbersOfCilinders) : 
            base(vehicleId, make, model, year, rentalRate) 
        { 
            NumbersOfDoors = numbersOfDoors;
            NumbersofCilinders = numbersOfCilinders;
        }

        //Implement a specialized method DisplayInfo() for Car object 
        public override string DisplayInfo()
        {
            return $"Vehicle Id {this.VehicleId}, make {this.Make}, model {Model}, year {this.Year}, Numebers of Doors {this.NumbersOfDoors}, and number of cilinders {this.NumbersofCilinders}";
        }
    }
}
