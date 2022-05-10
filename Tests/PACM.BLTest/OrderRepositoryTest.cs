using Microsoft.VisualStudio.TestTools.UnitTesting;
using PACM.BL;
using System;

namespace PACM.BLTest
{
    [TestClass]
    public class OrderRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            // -- Arrange
            var orderRepository = new OrderRepository();

            var expected = new Order(10)
            {
                OrderDate =  new System.DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0))
            };

            // -- Act
            var actual = orderRepository.Retrieve(10);

            // -- Assert
            Assert.AreEqual(expected.OrderDate, actual.OrderDate);
            
        }
    }
}      