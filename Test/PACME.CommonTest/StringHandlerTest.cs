using Microsoft.VisualStudio.TestTools.UnitTesting;
using PACME.Common;

namespace PACME.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpaceTestValid()
        {
            // -- Arrange
            var source = "SonicScrewdriver";
            var excepted = "Sonic Screwdriver";
            var handler = new StringHandler();

            // -- Act
            var actual = handler.InsertSpaces(source);

            // -- Assert
            Assert.AreEqual(excepted, actual);
        }
        [TestMethod]
        public void InsertSpacesTestWithExistingSpace()
        {
            // -- Arrange
            var source = "Sonic Screwdriver";
            var expected = "Sonic Screwdriver";
            var handler = new StringHandler();

            // -- act
            var actual = handler.InsertSpaces(source);

            // -- Assert
            Assert.AreEqual(expected, actual);
        }
    }
}