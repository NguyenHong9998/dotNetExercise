using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Test
{
    [TestClass]
    public class Exercise07Test
    {
        [TestMethod]
        public void TesFact()
        {
            Assert.AreEqual(new Exercise07().Factorial(1), 1);
            Assert.AreEqual(new Exercise07().Factorial(5), 120);
            Assert.AreEqual(new Exercise07().Factorial(0), 1);
        }
    }
}