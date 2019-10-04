using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeCalculator
{
    [TestClass]
    public class Tests
    {       
        [TestMethod]
        public void PlusDayTest1()
        {
            DateTime data = new DateTime(2019, 1, 1);
            var result = DateTimeCalc.PlusDay(data, 32);
            DateTime data1 = new DateTime(2019, 11, 11);
            Assert.AreEqual(data1, result);           
        }

        [TestMethod]
        public void PlusYearTest1()
        {
            DateTime data = new DateTime(2019, 10, 3);
            var result = DateTimeCalc.PlusYear(data, 6);
            DateTime data1 = new DateTime(2025, 10, 3);
            Assert.AreEqual(data1, result);
        }
        [TestMethod]
        public void PlusMonthTest1()
        {
            DateTime data = new DateTime(2019, 5, 3);
            var result = DateTimeCalc.PlusMonth(data, 6);
            DateTime data1 = new DateTime(2019, 11, 3);
            Assert.AreEqual(data1, result);
        }


    }
}
