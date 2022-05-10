using Microsoft.VisualStudio.TestTools.UnitTesting;
using PACM.BL;

namespace PACM.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            // -- Arrange
            var customerRepository = new CustomerRepository();

            //Remember, the CustomerId propert is 'private set', so we use the Constructor to set the customerId
            // We created an overloaded constructor to handle just that.
            var expected = new Customer(1)
            {
                EmailAdr = "fbaggins@hobbition.me",
                FirstName = "Frodo",
                LastName = "Baggins"
            };

            // -- Act
            var actual = customerRepository.Retrieve(1);

            // -- Assert
            // Notice: We cannot use the Assert funtionality in the "normal way". why? Becuase, if we compare the 2 objects, we will be
            //comparing their reference addresses. They are different objects, hence they will never be the same.
            // We need another approach.

            ////Assert.AreEqual(expected, actual);
            
            Assert.AreEqual(expected.CustomerID, actual.CustomerID);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.EmailAdr, actual.EmailAdr);
        }
    }
}      