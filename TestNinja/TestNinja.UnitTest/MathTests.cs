using NUnit.Framework;
using System;
using Math = TestNinja.Fundamentals.Math;

namespace TestNinja.UnitTest
{
    [TestFixture]
    public class MathTests
    {
        private Math _maths;

        [SetUp]
        public void SetUp()
        {
            _maths = new Math();
        }

        [Test]
        [Ignore("Because I wanted to")]
        public void Add_WhenCalled_ShouldReturnSumOfArguments()
        {
            var results = _maths.Add(3, 4);
            Assert.That(results, Is.EqualTo(7));
           
        }

        [Test]
        [TestCase(2,1,2)]
        [TestCase(1, 2, 2)]
        [TestCase(1, 1, 1)]
        public void Max_WhenCalled_ReturnTheGreaterArgument(int a,int b, int excpectedResults)
        {
            var results = _maths.Max(a, b);
            Assert.That(results, Is.EqualTo(excpectedResults));
           
        }

        
    }
}
