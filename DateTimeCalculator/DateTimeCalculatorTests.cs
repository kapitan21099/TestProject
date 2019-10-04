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
        public void DilTest1()
        {
            var res = DateTimeCalculator.DateTimeCalc.Dil(10, 5);
            Assert.AreEqual(2, res);
        }
        [TestMethod]
        public void DilTest2()
        {
            var res = DateTimeCalculator.DateTimeCalc.Dil(10, 0);
            Assert.AreEqual(0, res);
        }
        [TestMethod]
        public void PlusDayTest1()
        {
            DateTime data = new DateTime(2019, 10, 10);
            var result = DateTimeCalc.PlusDay(data, 10);
            DateTime data1 = new DateTime(2019, 10, 20);
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
