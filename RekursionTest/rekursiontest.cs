using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Rekursion;

namespace Test
{
    public class RecursionTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void fakultae_5_120()
        {
            rekursion factorial = new rekursion();
            int result = rekursion.fakultaet(5);
            Assert.AreEqual(120, result);
        }

        [Test]
        public void fibonacci_4_3()
        {
            rekursion factorial = new rekursion();
            int result = rekursion.fibonacci(4);
            Assert.AreEqual(3, result);
        }
    }
}