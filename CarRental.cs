using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicle_rental
{
    /// <summary>
    /// Derived class CarRental from the parent class 'AbstractRentalTransaction'
    /// </summary>
    internal class CarRental : AbstractRentalTransaction
    {
        //Properties required for the class CarRental
        public string CustomerName { get; set; }
        public DateTime ActualReturnDate { get; set; }

        //Parametarized Constructor 
        internal CarRental (int transactionId, DateTime rentalStartDate, DateTime rentalEndDate, string customerName, DateTime actualReturnDate) : 
            base (transactionId, rentalStartDate, rentalEndDate)
        {
            CustomerName = customerName;
            ActualReturnDate = actualReturnDate;
        }

        //Method to calculate the rental cost for Car instance 
        internal override double CalculateRentalCost(Vehicle vehicle)
        {
            // Calculating the days of rent
            TimeSpan differenceDays =  ActualReturnDate - RentalStartDate;
            double rentalCost = vehicle.RentalRate * (int)differenceDays.TotalDays;
            return rentalCost;
        }
    }
}
