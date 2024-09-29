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
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void LicensePlateTest_Invalid_LongerThan7Characters()
        {
            //arrange
            MC m3 = new MC();
            //act
            m3.Licenseplate = "12345678";
            //assert
            Assert.Fail();
        }
        [TestMethod()]
        public void LicensePlateTest_Valid_7Characters()
        {
            //arrange
            MC m3 = new MC();
            //act
            m3.Licenseplate = "1234567";
            //assert
            Assert.AreEqual(m3.Licenseplate, "1234567");
        }
    }
}