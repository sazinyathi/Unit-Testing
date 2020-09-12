using NUnit.Framework;
using System;
using System.Linq;
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
        [Test]
        public void GetOddNumbers_LimitIsGreaterThanZero_ReturnOddNumbersUpToLimit()
        {
            var results =_maths.GetOddNumbers(5);
           // Assert.That(results, Is.Not.Empty); // general you cannot write all these assertion
          //  Assert.That(results.Count(),Is.EqualTo(3));//

           // Assert.That(results, Does.Contain(1));//
          //  Assert.That(results, Does.Contain(3));//
          //  Assert.That(results, Does.Contain(5));//
          // Assert.That(results,Is.Orderd);
          // Assert.That(results,
            Assert.That(results, Is.EquivalentTo(new [] { 1, 3, 5 }));
        }
        
    }
}
