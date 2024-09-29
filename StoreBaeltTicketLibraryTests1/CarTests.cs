using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltTicketLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;

namespace StoreBaeltTicketLibrary.Tests
{
    [TestClass()]
    [ExcludeFromCodeCoverage]
    public class CarTests
    {
        [DataTestMethod()]
        [DataRow(30, 240, false)]
        [DataRow(30, 228, true)]
        [DataRow(29,192,false)]
        [DataRow(29,182.4,true)]
        public void PriceTest_Valid_ExpectedPrices(int date,double expectedPrice, bool brobizz)
        {
            //arrange
            Car car = new Car();
            car.Date = new DateTime(2024, 09, date);
            car.Brobizz = brobizz;
            //act
            double actualPrice = car.Price();
            //assert
            Assert.AreEqual(expectedPrice, actualPrice,0.01);
        }
    }
}