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
        public void PriceTest_Valid_228_Brobizz()
        {
            //arrange
            Car c1 = new Car();
            c1.Brobizz = true;
            //act
            double c1price = c1.Price();
            //assert
            Assert.AreEqual(c1price, 228,0.01);
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
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void LicensePlateTest_Invalid_LongerThan7Characters()
        {
            //arrange
            Car c3 = new Car();
            //act
            c3.Licenseplate = "12345678";
            //assert
            Assert.Fail();
        }
        [TestMethod()]
        public void LicensePlateTest_Valid_7Characters()
        {
            //arrange
            Car c3 = new Car();
            //act
            c3.Licenseplate = "1234567";
            //assert
            Assert.AreEqual(c3.Licenseplate, "1234567");
        }
    }
}