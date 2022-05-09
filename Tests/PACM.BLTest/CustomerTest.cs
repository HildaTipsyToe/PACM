using Microsoft.VisualStudio.TestTools.UnitTesting;
using PACM.BL;

namespace PACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //-- Arrange
            // Using an object initializer to create a Test Customer Object
            Customer customer = new Customer
            {
                FirstName = "Bilbo",
                LastName = "Baggins"
            };

            // Variable to hold the expected result when acutally running the FullName Property
            string expected = "Baggins,Bilbo";

            //-- Act
            //Acutally performing the opreation we are testing
            string actual = customer.FullName;
            
            //-- Assert
            //Verifying the expected value equals the actual value
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //-- Arrange
            // Using an object initializer to create a Test Customer Object
            Customer customer = new Customer
            {
                LastName = "Baggins"
            };

            // Variable to hold the expected result when acutally running the FullName Property
            string expected = "Baggins";

            //-- Act
            //Acutally performing the opreation we are testing
            string actual = customer.FullName;

            //-- Assert
            //Verifying the expected value equals the actual value
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //-- Arrange
            // Using an object initializer to create a Test Customer Object
            Customer customer = new Customer
            {
                FirstName = "Bilbo",
            };

            // Variable to hold the expected result when acutally running the FullName Property
            string expected = "Bilbo";

            //-- Act
            //Acutally performing the opreation we are testing
            string actual = customer.FullName;

            //-- Assert
            //Verifying the expected value equals the actual value
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ValidateValid()
        {

            //-- Arrange
            // Using an object initializer to create a Test Customer Object
            var customer = new Customer
            {
                LastName = "Baggins",
                EmailAdr = "fbaggins@hobbiton.me"
            };
            // Variable to hold the expected result when acutally running the FullName Property

            var expected = true;

            //-- Act
            //Acutally performing the opreation we are testing
            var acutally = customer.Validate();

            //-- Assert
            //Verifying the expected value equals the actual value
            Assert.AreEqual(expected, acutally);

        }
        [TestMethod]
        public void ValidateMissingLastName()
        {
            //-- Arrange
            // Using an object initializer to create a Test Customer Object
            var customer = new Customer
            {
                EmailAdr = "fbaggins@hobbiton.me"
            };
            // Variable to hold the expected result when acutally running the FullName Property

            var expected = false;

            //-- Act
            //Acutally performing the opreation we are testing
            var acutally = customer.Validate();

            //-- Assert
            //Verifying the expected value equals the actual value
            Assert.AreEqual(expected, acutally);
        }
    }
}      