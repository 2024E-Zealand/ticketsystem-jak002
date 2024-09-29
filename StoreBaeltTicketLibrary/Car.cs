namespace StoreBaeltTicketLibrary
{
    /// <summary>
    /// A representation of cars needing to be ticketed, customized for Storebælt
    /// </summary>
    public class Car : TicketClassLibrary.Car
    {
        /// <summary>
        /// Calculates the price for this vehicle's crossing, taking weekend discounts into account.
        /// </summary>
        /// <returns>The crossing's price, in dkk</returns>
        public override double Price()
        {
            if (Date.DayOfWeek == DayOfWeek.Sunday || Date.DayOfWeek == DayOfWeek.Saturday)
            {
                double price = 240 * 0.8;
                return Brobizz ? price * 0.95 : price;
            }
            return base.Price();
        }
    }
}
