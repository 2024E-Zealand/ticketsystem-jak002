using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OresundTicketLibrary
{
    /// <summary>
    /// A representation of motorcycles needing to be ticketed, customized for Oresundsbron
    /// </summary>
    public class MC : TicketClassLibrary.MC
    {
        /// <summary>
        /// Calculates the price for this vehicle's crossing.
        /// </summary>
        /// <returns>The crossing's price, in dkk</returns>
        public override double Price()
        {
            return Brobizz ? 73 : 210;
        }

        /// <summary>
        /// Returns the type of vehicle, for categorization
        /// </summary>
        /// <returns>A string signifying the type of vehicle</returns>
        public override string VehicleType()
        {
            return "Oresund MC";
        }
    }
}
