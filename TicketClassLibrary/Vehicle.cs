using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketClassLibrary
{
    /// <summary>
    /// The base class for all vehicles. Keep in mind, this is abstract and must be inherited.
    /// </summary>
    public abstract class Vehicle
    {
        private string licenseplate;
        /// <summary>
        /// The unique license plate, used for identifying the vehicle.
        /// </summary>
        protected string Licenseplate { get { return licenseplate; } set 
            {
                if (value.Length > 7)
                {
                    throw new ArgumentException("License plate too long");
                } else
                {
                    licenseplate = value;
                }
            }
        }

        /// <summary>
        /// Specifies whether Brobizz was used, and consequently, if a discount should be applied
        /// </summary>
        protected bool Brobizz { get; set; }
        /// <summary>
        /// The date at which the vehicle has crossed, given as a DateTime object.
        /// </summary>
        protected DateTime Date { get; set; }

        /// <summary>
        /// Calculates the price for this vehicle's crossing.
        /// </summary>
        /// <returns>The crossing's price, in dkk</returns>
        public abstract double Price();

        /// <summary>
        /// Returns the type of vehicle, for categorization
        /// </summary>
        /// <returns>A string signifying the type of vehicle</returns>
        public abstract string VehicleType();
    }
}
