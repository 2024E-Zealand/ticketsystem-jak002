using TicketClassLibrary;

namespace StoreBaeltTicketLibrary
{
    /// <summary>
    /// A repository for handling all tickets on Storebælt
    /// </summary>
    public interface IStoreBaeltRepository
    {
        /// <summary>
        /// STATIC: Adds a single ticket to the repository
        /// </summary>
        /// <param name="ticket">Ticket to be added</param>
        /// <returns>The ticket object if successful, otherwise null</returns>
        Vehicle? Add(Vehicle ticket);
        /// <summary>
        /// Returns a list of all tickets added so far
        /// </summary>
        /// <returns>A list of all tickets</returns>
        List<Vehicle> GetAll();
        /// <summary>
        /// Returns a list of all tickets belonging to a given licenseplate
        /// </summary>
        /// <param name="licensePlate">The license plate to search for</param>
        /// <returns>The aforementioned list if found, otherwise an empty list</returns>
        List<Vehicle> GetByLicensePlate(string licensePlate);
    }
}