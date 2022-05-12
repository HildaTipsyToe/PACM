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


            // -- Act
            // var actual = StringHandler.InsertSpaces(source);
            var actual = source.InsertSpaces();

            // -- Assert
            Assert.AreEqual(excepted, actual);
        }
        [TestMethod]
        public void InsertSpacesTestWithExistingSpace()
        {
            // -- Arrange
            var source = "Sonic Screwdriver";
            var expected = "Sonic Screwdriver";

            // -- act
            // var actual = StringHandler.InsertSpaces(source);
            var actual = source.InsertSpaces();

            // -- Assert
            Assert.AreEqual(expected, actual);
        }
    }
}