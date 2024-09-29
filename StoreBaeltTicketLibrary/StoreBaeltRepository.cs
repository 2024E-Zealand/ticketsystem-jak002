using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketClassLibrary;

namespace StoreBaeltTicketLibrary
{
    /// <summary>
    /// A repository for handling all tickets on Storebælt
    /// </summary>
    public class StoreBaeltRepository
    {
        /// <summary>
        /// Static list for holding all tickets
        /// </summary>
        private static List<Vehicle> _tickets = new List<Vehicle>();

        /// <summary>
        /// STATIC: Adds a single ticket to the repository
        /// </summary>
        /// <param name="ticket">Ticket to be added</param>
        /// <returns>The ticket object if successful, otherwise null</returns>
        public static Vehicle? Add(Vehicle ticket)
        {
            _tickets.Add(ticket);
            return ticket;
        }

        /// <summary>
        /// Returns a list of all tickets added so far
        /// </summary>
        /// <returns>A list of all tickets</returns>
        public static List<Vehicle> GetAll()
        {
            return _tickets;
        }

        /// <summary>
        /// Returns a list of all tickets belonging to a given licenseplate
        /// </summary>
        /// <param name="licensePlate">The license plate to search for</param>
        /// <returns>The aforementioned list</returns>
        public static List<Vehicle> GetByLicensePlate(string licensePlate)
        {
            return _tickets.FindAll(t => t.Licenseplate == licensePlate);
        }
    }
}
