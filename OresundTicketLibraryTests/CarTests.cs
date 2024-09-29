using Microsoft.VisualStudio.TestTools.UnitTesting;
using OresundTicketLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OresundTicketLibrary.Tests
{
    [TestClass()]
    [ExcludeFromCodeCoverage]
    public class CarTests
    {
        [TestMethod()]
        public void PriceTest_Valid_410()
        {
            //arrange
            Car c1 = new Car();
            //act
            double c1price = c1.Price();
            //assert
            Assert.AreEqual(c1price, 410);
        }
        [TestMethod()]
        public void PriceTest_Valid_161_Brobizz()
        {
            //arrange
            Car c1 = new Car();
            c1.Brobizz = true;
            //act
            double c1price = c1.Price();
            //assert
            Assert.AreEqual(c1price, 161);
        }
        [TestMethod()]
        public void VehicleTypeTest_Valid_OresundCar()
        {
            //arrange
            Car c2 = new Car();
            //act
            string c2type = c2.VehicleType();
            //assert
            Assert.AreEqual(c2type, "Oresund car");
        }
    }
}