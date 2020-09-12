using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTest
{
    [TestFixture]
   public class ErrorLoggerTest
    {
        private ErrorLogger _errorLogger;

        [SetUp]
        public void SetUp()
        {
            _errorLogger = new ErrorLogger();
        }

        [Test]
        [TestCase("a")]
        public void Log_WhenCalled_SetTheLastErrorProperty(string error)
        {
            _errorLogger.Log(error);
            Assert.That(_errorLogger.LastError, Is.EqualTo(error));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void Log_InvalidError_ThrowArgumentNullException(string error)
        {
            //for exception use delegate
            Assert.That(() => _errorLogger.Log(error), Throws.ArgumentNullException);
        }

       
    }
}
