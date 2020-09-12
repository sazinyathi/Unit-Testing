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
    public class CustomerControllerTest
    {
        private CustomerController _customerController;

        [SetUp]
        public void SetUp()
        {
            _customerController = new CustomerController();
        }

        [Test]
       
        public void CustomerController_IdIsZero_ShouldReturnNotFound()
        {
            var results =_customerController.GetCustomer(0);
            //Not found
            Assert.That(results, Is.TypeOf<NotFound>());
            // NotFound or one of its derivatves
           // Assert.That(results, Is.InstanceOf<NotFound>());
        }

        [Test]
        public void CustomerController_IdIsOne_ShouldReturnOk()
        {
            var results = _customerController.GetCustomer(1);
            //Not found
            Assert.That(results, Is.TypeOf<Ok>());
            // NotFound or one of its derivatves
            // Assert.That(results, Is.InstanceOf<NotFound>());
        }
    }
}
