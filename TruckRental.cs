using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicle_rental
{
    /// <summary>
    /// Derived class TruckRental from the parent class 'AbstractRentalTransaction'
    /// </summary>
    internal class TruckRental : AbstractRentalTransaction
    {
        //Properties required for the class TruckRental
        public string CustomerName { get; set; }
        public DateTime ActualReturnDate { get; set; }

        //Parametarized Constructor 
        TruckRental(int transactionId, DateTime rentalStartDate, DateTime rentalEndDate, string customerName, DateTime actualReturnDate) : 
            base (transactionId, rentalStartDate, rentalEndDate)
        {
            CustomerName = customerName;
            ActualReturnDate = actualReturnDate;
        }

        //Method to calculate the rental cost for truck instance 
        internal override double CalculateRentalCost(Vehicle vehicle)
        {
            // Include calculation with 1 Day Free - implementation for Truck Rentals
            TimeSpan differenceDays =  ActualReturnDate - RentalStartDate;
            double rentalCost = vehicle.RentalRate * (int)differenceDays.TotalDays-1;
            return rentalCost;
        }
    }
}
