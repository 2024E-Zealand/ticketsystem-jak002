namespace TicketClassLibrary
{
    /// <summary>
    /// A representation of motorcycles needing to be ticketed.
    /// </summary>
    public class MC : Vehicle
    {
        /// <summary>
        /// The unique license plate, used for identifying the vehicle
        /// </summary>
        public string Licenseplate { get { return base.Licenseplate; } set { base.Licenseplate = value; } }

        /// <summary>
        /// The date at which the vehicle has crossed, given as a DateTime object.
        /// </summary>
        public DateTime Date { get { return base.Date; } set { base.Date = value; } }
        /// <summary>
        /// Specifies whether Brobizz was used, and consequently, if a discount should be applied
        /// </summary>
        public bool Brobizz { get { return base.Brobizz; } set { base.Brobizz = value; } }

        /// <summary>
        /// Calculates the price for this vehicle's crossing.
        /// </summary>
        /// <returns>The crossing's price, in dkk</returns>
        public override double Price()
        {
            if (Brobizz)
            {
                return 125 * 0.95;
            }
            return 125;
        }
        /// <summary>
        /// Returns the type of vehicle, for categorization
        /// </summary>
        /// <returns>A string signifying the type of vehicle</returns>
        public override string VehicleType()
        {
            return "MC";
        }
    }
}
