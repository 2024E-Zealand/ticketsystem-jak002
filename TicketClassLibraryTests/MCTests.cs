using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketClassLibrary.Tests
{
    [TestClass()]
    public class MCTests
    {
        [TestMethod()]
        public void PriceTest_Valid_125()
        {
            //arrange
            MC m1 = new MC();
            //act
            double m1price = m1.Price();
            //assert
            Assert.AreEqual(m1price, 125);
        }

        [TestMethod()]
        public void VehicleTest_Valid_MC()
        {
            //arrange
            MC m2 = new MC();
            //act
            string m2vehicle = m2.VehicleType();
            //assert
            Assert.AreEqual(m2vehicle, "MC");
        }
    }
}