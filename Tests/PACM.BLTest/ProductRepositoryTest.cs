using Microsoft.VisualStudio.TestTools.UnitTesting;
using PACM.BL;

namespace PACM.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            // -- Arrange
            var productRepository= new ProductRepository();

            var expected = new Product(2)
            {
                ProductName = "Sunflowers",
                ProductDescription = "Assorted Size Set of 4 Bright Yellow Mini Sunflowers",
                CurrentPrice = 15.96M
        };

            // -- Act
            var actual = productRepository.Retrieve(2);

            // -- Assert
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
            Assert.AreEqual(expected.ProductName, actual.ProductName);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
        }
    }
}      