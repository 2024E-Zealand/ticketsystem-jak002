using Microsoft.VisualStudio.TestTools.UnitTesting;
using OresundTicketLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OresundTicketLibrary.Tests
{
    [TestClass()]
    public class MCTests
    {
        [TestMethod()]
        public void PriceTest_Valid_210()
        {
            //arrange
            MC m1 = new MC();
            //act
            double m1price = m1.Price();
            //assert
            Assert.AreEqual(m1price, 210);
        }
        [TestMethod()]
        public void PriceTest_Valid_73_Brobizz()
        {
            //arrange
            MC m1 = new MC();
            m1.Brobizz = true;
            //act
            double m1price = m1.Price();
            //assert
            Assert.AreEqual(m1price, 73);
        }

        [TestMethod()]
        public void VehicleTest_Valid_OresundMC()
        {
            //arrange
            MC m2 = new MC();
            //act
            string m2vehicle = m2.VehicleType();
            //assert
            Assert.AreEqual(m2vehicle, "Oresund MC");
        }
    }
}