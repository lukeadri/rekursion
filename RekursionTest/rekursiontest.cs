using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Rekursion;

namespace Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void fakultätof5()
        {
            rekursion factorial = new rekursion();
            int result = rekursion.fakultät(5);
            Assert.AreEqual(120, result);
        }

        [Test]
        public void fibonacciof4()
        {
            rekursion factorial = new rekursion();
            int result = rekursion.fibonacci(4);
            Assert.AreEqual(3, result);
        }
    }
}