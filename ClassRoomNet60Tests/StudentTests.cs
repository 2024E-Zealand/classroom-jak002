using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassRoomNet60;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60.Tests
{
    [TestClass()]
    public class StudentTests
    {
        [DataTestMethod()]
        [DataRow(1, "Winter")]
        [DataRow(2, "Winter")]
        [DataRow(12, "Winter")]
        [DataRow(3, "Spring")]
        [DataRow(4, "Spring")]
        [DataRow(5, "Spring")]
        [DataRow(6, "Summer")]
        [DataRow(7, "Summer")]
        [DataRow(8, "Summer")]
        [DataRow(9, "Autumn")]
        [DataRow(10, "Autumn")]
        [DataRow(11, "Autumn")]
        public void SeasonTest_valid(int month, string expected)
        {
            Student s = new("test", month, 1);
            string result = s.Season();
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod()]
        [DataRow(0)]
        [DataRow(13)]
        [DataRow(5000)]
        [ExpectedException(typeof(ArgumentException))]
        public void SeasonTest_invalid(int month)
        {
            Student s = new("test", month, 1);
            string result = s.Season();
            Assert.Fail();
        }
    }
}