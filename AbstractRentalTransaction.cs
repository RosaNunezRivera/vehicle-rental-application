using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicle_rental
{
    /// <summary>
    /// Abstract class to use like blueprint to create derived class CarRental y TruckRental 
    /// </summary>
    internal abstract class AbstractRentalTransaction
    {
        //Properties required for the class AbstractRentalTransaction
        public int TransactionId { get; set; }
        public DateTime RentalStartDate { get; set; }
        public DateTime RentalEndDate { get; set; }

        //Parametarized Constructor 
        internal AbstractRentalTransaction(int transactionId, DateTime rentalStartDate, DateTime rentalEndDate) 
        {
            TransactionId = transactionId;
            RentalStartDate = rentalStartDate;
            RentalEndDate = rentalEndDate;
        }

        //Abstract method to calculate the rental cost 
        internal abstract double CalculateRentalCost(Vehicle vehicle);
    }
}
