namespace OresundTicketLibrary
{
    /// <summary>
    /// A representation of cars needing to be ticketed, customized for Oresundsbron
    /// </summary>
    public class Car : TicketClassLibrary.Car
    {
        /// <summary>
        /// Calculates the price for this vehicle's crossing.
        /// </summary>
        /// <returns>The crossing's price, in dkk</returns>
        public override double Price()
        {
            return Brobizz ? 161 : 410;
        }

        /// <summary>
        /// Returns the type of vehicle, for categorization
        /// </summary>
        /// <returns>A string signifying the type of vehicle</returns>
        public override string VehicleType()
        {
            return "Oresund car";
        }
    }
}
