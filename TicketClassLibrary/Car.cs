namespace TicketClassLibrary
{
    /// <summary>
    /// A representation of cars needing to be ticketed.
    /// </summary>
    public class Car
    {
        /// <summary>
        /// The unique license plate, used for identifying the vehicle
        /// </summary>
        public string Licenseplate { get; set; }

        /// <summary>
        /// The date at which the vehicle has crossed, given as a DateTime object.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Calculates the price for this vehicle's crossing.
        /// </summary>
        /// <returns>The crossing's price, in dkk</returns>
        public double Price()
        {
            return 240;
        }
        /// <summary>
        /// Returns the type of vehicle, for categorization
        /// </summary>
        /// <returns>A string signifying the type of vehicle</returns>
        public string VehicleType()
        {
            return "Car";
        }
    }
}
