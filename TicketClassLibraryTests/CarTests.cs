using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;

namespace TicketClassLibrary.Tests
{
    [TestClass()]
    [ExcludeFromCodeCoverage]
    public class CarTests
    {
        [TestMethod()]
        public void PriceTest_Valid_240()
        {
            //arrange
            Car c1 = new Car();
            //act
            double c1price = c1.Price();
            //assert
            Assert.AreEqual(c1price, 240);
        }

        [TestMethod()]
        public void VehicleTypeTest_Valid_Car()
        {
            //arrange
            Car c2 = new Car();
            //act
            string c2type = c2.VehicleType();
            //assert
            Assert.AreEqual(c2type,"Car");
        }
    }
}