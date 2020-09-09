

using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTest
{
    [TestFixture]
    public class ReservationTests
    {
        [Test]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            //Arrange,Act,Assert
            var reservation = new Reservation();
            var results =reservation.CanBeCancelledBy(new User { IsAdmin = true });
            Assert.IsTrue(results);

           
        }

        [Test]
        public void CanBeCancelledBy_SameUser_ReturnsTrue()
        {
            //Arrange,Act,Assert
            var user = new User ();
            var reservation = new Reservation() {MadeBy = user};
            var results = reservation.CanBeCancelledBy(reservation.MadeBy);
            Assert.IsTrue(results);


        }

        [Test]
        public void CanBeCancelledBy_UserAnotherUser_ReturnsTrue()
        {
            //Arrange,Act,Assert
            var user = new User();
            var reservation = new Reservation();
            var results = reservation.CanBeCancelledBy(user);
            Assert.IsFalse(results);


        }
    }
}
