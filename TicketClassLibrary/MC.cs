namespace TicketClassLibrary
{
    /// <summary>
    /// A representation of motorcycles needing to be ticketed.
    /// </summary>
    public class MC
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
            return 125;
        }
        /// <summary>
        /// Returns the type of vehicle, for categorization
        /// </summary>
        /// <returns>A string signifying the type of vehicle</returns>
        public string Vehicle()
        {
            return "MC";
        }
    }
}
