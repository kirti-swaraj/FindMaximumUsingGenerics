using Microsoft.VisualStudio.TestTools.UnitTesting;
using GenericsTestMaximum;

namespace MSTestFindMax
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        /// <summary>
        /// UC 1.1 : Given the maximum number at first position returns the same number.
        /// </summary>
        
        public void GivenMaxNumberAtFirstPos_ReturnTheSameNumber()
        {
            //Arrange
            int expected = 50;
            //Act
            int actual = FindMaximum.MaxIntegerAmongThree(50, 30, 10);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// UC 1.2 : Given the maximum number at second position returns the same number.
        /// </summary>
        [TestMethod]
        public void GivenMaxNumberAtSecondPos_ReturnTheSameNumber()
        {
            //Arrange
            int expected = 80;
            //Act
            int actual = FindMaximum.MaxIntegerAmongThree(50, 80, 10);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// UC 1.3 : Given the maximum number at third position returns the same number.
        /// </summary>
        [TestMethod]
        public void GivenMaxNumberAtThirdPos_ReturnTheSameNumber()
        {
            //Arrange
            int expected = 100;
            //Act
            int actual = FindMaximum.MaxIntegerAmongThree(50, 30, 100);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}